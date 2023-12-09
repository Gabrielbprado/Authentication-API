﻿using Authentication_API.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Authentication_API.Services;


public class TokenService
{
    public string GenerateToken(User user)
    {

        Claim[] claims = new Claim[]
        {
             new Claim("username", user.UserName),
             new Claim("id",user.Id),
             new Claim(ClaimTypes.DateOfBirth,user.DateBirth.ToString())
        };
        var key =  new SymmetricSecurityKey(Encoding.UTF8.GetBytes("9A4F2C5E1D6B9C8A3F0D7E5B4A1C3F2E1A9C8B5D2F1C0D8A7E4B5A3D0F7C4D3E2F0A1D5E3B4F2D1C0B7E8A6C9D3F0E1D7C5B2A4C1F3E2D0B8F5C4A7D9E0F3A2D6C1E8A3C9D0E7A4D8E9C3B0F6C1A2D4E6A9B8C5D7A1E2F9A6C4D0A2E7C9B3F2E1D0C8F7E4D5A2B9C3A8F0D2C6B7E9C0A3D7E1F5B4A2D6E9C8B0F3A1E4C5A6B9F2C8A1D0E2C7A3B8E4D0E6A2C4F3A7E9B0D8E3C1F5E2A3D7C0A2E5B1C8D0F2A4C6D8E9A2C4D3E8F1A7D4B6C9F0D7A1E5C3D9F4E0C2B7E3A9C6B5D8E7A2F1D0E5C3D8A9E6C0B9D4E3F0B2E1D5C4F2E0A7C3B1D7A2E8C5D9F3B0E6C8A5D2F4A6D8C1E0B3F2C9A0E7B6C3A8F1D2C4A5B9C0D3F6E2D0B4C8E3D6C5A8E9C2D4F0B6C7D3A5B0C1D6E2A9F0D4B7C9E6F1D8A4B1C3D0A6C2B5F0C4A1E8D3B2C7A0F2A5D9C6E2D4F1B9C0A7D2F5C8A3D6A1B2C9A8F1C5B6E2C4A9D8F7C0D2A1C6D8B5E3D4C9B7E6A2F3D1C8E7D3F2A4E6D2C1B8F7E4C0A2D9C5A7D4E1F0C2B9A8F3D2E6B7D9F0C3A1E5C2D7A4F1C8E3A0C7D4F5E6C8D9F3C0E7B5D4C2A1F0B7E3C9D8E4B5C0A7E9F2C8D6E4C3A2B8D9A1E2F5C0D8B1E7D4C6A8D3F0A6C1B7D5E9F3A2B6D0A8C3E5D4C1F3E2A6B7C8E9B5D2C6A1E7D4F5A3D8C0E6B9D2C5A7D1E4C2B3D5A2F0E7C8D1F5E3B9A4D7C2B1E9F4A3D0C6A8F1E3D5C0B7F2A1C8E6D3A5F0E8B1C7E4A0C2D8A7E2B4D1E6F0B8D3C2E0F5A3C8B9D1A5E7C2D0F3B6E4D8A9F1B2C3A7D4F6A9D8E1C2F0E5A3B1F2D0A8E7C5D9F3B6C1D0A2E4F0D7B5C9A0D8B2F1A3D6C8A5D2E4C7D9E0C3F1B6E2A8D3C0B1E6A2F0E8C5A1D7E9B4C0F3A6D2E9F4C1A5E0C8D3F2A1E7C4B0D9F3A8E2C0D7A9E4C8B1E2F3A0D8E6C5A3F1C9D7E0A4C2E8B9C3A5E6A0C8D1F2E7C4A6F3D0E1C2A7F0C8A3E5B2D9E8C7B1D3A6E2A7F0D9C6E8B1C2F5A3D8C9E2C1A7D4C3F0E7A9B0D8C6E2A4D7C1E3B2A8C5F0E1D6C9A2E3C0D7A5E9B6C3A1F0D9E2F4C5D0E8F2C3B1E6A2F5C1D9F0C4B7E2C1A8E4D0C6A1F3E2D7A6B3D9E0A4C1E6F0D2C5A3F1E2A7C3B5D8A6C0F2E3D7C1B9E6A0D2C8B1E5C2F0A7D3C5B8F1A4D9C2E5D4C8A3E7F0C1E6A4D2B9C0F3A7D4C6A8F1C5D3E9A6B2C8D0A1C4B7D3F0A6C1B3E2A7F1E4A0C9D8F3A7E1C2B6D9E6F1D8A3C0A2E7B4C9D2E4F0A7D3C0A2E5B1C8D0F2A4C6D8E9A2C4D3E8F1A7D4B6C9F0D7A1E5C3D9F4E0C2B7E3A9C6B5D8E7A2F1D0E5C3D8A9E6C0B9D4E3F0B2E1D5C4F2E0A7C3B1D7A2E8C5D9F3B0E6C8A5D2F4A6D8C1E0B3F2C9A0E7B6C3A8F1D2C4A5B9C0D3F6E2D0B4C8E3D6C5A8E9C2D4F0B6C7D3A5B0C1D6E2A9F0D4B7C9E6F1D8A4B1C3D0A6C2B5F0C4A1E8D3B2C7A0F2A5D9C6E2D4F1B9C0A7D2F5C8A3D6A1B2C9A8F1C5B6E2C4A9D8F7C0D2A1C6D8B5E3D4C9B7E6A2F3D1C8E7D3F2A4E6D2C1B8F7E4C0A2D9C5A7D4E1F0C2B9A8F3D2E6B7D9F0C3A1E5C2D7A4F1C8E3A0C7D4F5E6C8D9F3C0E7B5D4C2A1F0B7E3C9D8E4B5C0A7E9F2C8D6E4C3A2B8D9A1E2F5C0D8B1E7D4C6A8D3F0A6C1B7D5E9F3A2B6D0A8C3E5D4C1F3E2A6B7C8E9B5D2C6A1E7D4F5A3D8C0E6B9D2C5A7D1E4C2B3D5A2F0E7C8D1F5E3B9A4D7C2B1E9F4A3D0C6A8F1E3D5C0B7F2A1C8E6D3A5F0E8B1C7E4A0C2D8A7E2B4D1E6F0B8D3C2E0F5A3C8B9D1A5E7C2D0F3B6E4D8A9F1B2C3A7D4F6A9D8E1C2F0E5A3B1F2D0A8E7C5D9F3B6C1D0A2E4F0D7B5C9A0D8B2F1A3D6C8A5D2E4C7D9E0C3F1B6E2A8D3C0B1E6A2F0E8C5A1D7E9B4C0F3A6D2E9F4C1A5E0C8D3F2A1E7C4B0D9F3A8E2C0D7A9E4C8B1E2F3A0D8E6C5A3F1C9D7E0A4C2E8B9C3A5E6A0C8D1F2E7C4A6F3D0E1C2A7F0C8A3E5B2D9E8C7B1D3A6E2A7F0D9C6E8B1C2F5A3D8C9E2C1A7D4C3F0E7A9B0D8C6E2A4D7C1E3B2A8C5F0E1D6C9A2E3C0D7A5E9B6C3A1F0D9E2F4C5D0E8F2C3B1E6A2F5C1D9F0C4B7E2C1A8E4D0C6A1F3E2D7A6B3D9E0A4C1E6F0D2C5A3F1E2A7C3B5D8A6C0F2E3D7C1B9E6A0D2C8B1E5C2F0A7D3C5B8F1A4D9C2E5D4C8A3E7F0C1E6A4D2B9C0F3A7D4C6A8F1C5D3E9A6B2C8D0A1C4B7D3F0A6C1B3E2A7F1E4A0C9D8F3A7E1C2B6D9E6F1D8A3C0A2E7B4C9D2E4F0A7D3C0A2E5B1C8D0F2A4C6D8E9A2C4D3E8F1A7D4B6C9F0D7A1E5C3D9F4E0C2B7E3A9C6B5D8E7A2F1D0E5C3D8A9E6C0B9D4E3F0B2E1D5C4F2E0A7C3B1D7A2E8C5D9F3B0E\r\n"));
        var signingCredentials = new SigningCredentials(key,SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken
            (
                expires: DateTime.Now.AddMinutes(10),
                claims : claims,
                signingCredentials : signingCredentials
            ); 
        
        return new JwtSecurityTokenHandler().WriteToken(token);
            


}
}