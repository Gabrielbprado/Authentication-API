using Authentication_API.Data.Dtos;
using Authentication_API.Models;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using System;

namespace Authentication_API.Services;

public class UserService
{
    private readonly IMapper _mapper;
    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;
    private readonly TokenService _tokenService;

    public UserService(IMapper mapper, UserManager<User> userManager, SignInManager<User> signInManager, TokenService token)
    {
        _mapper = mapper;
        _userManager = userManager;
        _signInManager = signInManager;
        _tokenService = token;
        
    }

    public async Task CadastreAsync(CreatedUserDto dto)
    {
        User user = _mapper.Map<User>(dto);
        IdentityResult Result = await _userManager.CreateAsync(user, dto.Password);
        if (!Result.Succeeded) throw new ApplicationException("Error the Registered a User");

    }

    public async Task<string> LoginAsync(LoginUserDto dto)
    {
        var result = await _signInManager.PasswordSignInAsync(dto.UserName, dto.Password, false, false);
        if (!result.Succeeded) throw new ApplicationException("Error ao perform the Login");
        var user = _signInManager.UserManager.Users.FirstOrDefault(x => x.NormalizedUserName == dto.UserName.ToUpper());
        var token = _tokenService.GenerateToken(user);
        return token;


    }
}
