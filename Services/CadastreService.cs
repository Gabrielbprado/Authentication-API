using Authentication_API.Data.Dtos;
using Authentication_API.Models;
using AutoMapper;
using Microsoft.AspNetCore.Identity;

namespace Authentication_API.Services;

public class CadastreService
{
    private IMapper _mapper;
    private UserManager<User> _userManager;
    public CadastreService(IMapper mapper, UserManager<User> userManager)
    {
        _mapper = mapper;
        _userManager = userManager;
    }

    public async Task CadastreAsync(CreatedUserDto dto)
    {
        User user = _mapper.Map<User>(dto);
        IdentityResult Result = await _userManager.CreateAsync(user, dto.Password);
        if (!Result.Succeeded) throw new ApplicationException("Error the Registered a User");

    }
}
