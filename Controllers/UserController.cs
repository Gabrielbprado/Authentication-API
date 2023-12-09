using Authentication_API.Data.Dtos;
using Authentication_API.Models;
using Authentication_API.Services;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Authentication_API.Controllers;
[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{

    private UserService _userService { get; set; }

    public UserController(UserService cadastreService)
    {
        _userService = cadastreService;
    }

    [HttpPost("cadastre")]
    public async Task<IActionResult> CreatedUser(CreatedUserDto dto)
    {
       await _userService.CadastreAsync(dto);
        return Ok("User Cadastred Successfully");
    }
    [HttpPost("login")]
    public async Task <IActionResult> SiginUser(LoginUserDto dto)
    {
       var token = await _userService.LoginAsync(dto);
        return Ok($"Login Successfully Performed, Token Genereted: {token}");
    }
}

