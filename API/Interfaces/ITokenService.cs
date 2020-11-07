using System;
using API.Entities;
using System.IdentityModel.Tokens;
namespace API.Interfaces
{
public interface ITokenService
{
        string CreateToken(AppUser user);
}
 }