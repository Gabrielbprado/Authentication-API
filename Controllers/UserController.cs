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

    private CadastreService _cadastreService { get; set; }

    public UserController(CadastreService cadastreService)
    {
        _cadastreService = cadastreService;
    }

    [HttpPost]
    public async Task<IActionResult> PostUserAsync(CreatedUserDto dto)
    {
       await _cadastreService.CadastreAsync(dto);
        return Ok("User Cadastred Successfully");
    }
}

