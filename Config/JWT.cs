using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using BooksHotelFullRestAPI.Models;

namespace BooksHotelFullRestAPI.Config;

public class JWT
{
    // Method to generate the JWT.
    public static string GenerateJwtToken(Employee employee)
    {
        // Create a security key using the secret key from the configuration.
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("JWT_KEY"));

        // Create signing credentials using the security key and HMAC-SHA256 algorithm.
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        // Define the claims that will be included in the JWT (OPCIONAL).
        var claims = new[]
        {
            new Claim("Id", employee.Id.ToString()),
            new Claim("First name", employee.FirstName),
            new Claim("Last name", employee.LastName),
            new Claim("Email", employee.Email),
        };

        // Create the JWT with the configured parameters.
        var token = new JwtSecurityToken(
            issuer: "JWT_ISSUER", // Token issuer.
            audience: "JWT_AUDIENCE", // Token audience.
            claims: claims, // Claims to be included in the token.
            expires: DateTime.Now.AddMinutes(Convert.ToDouble("JWT_EXPIREMINUTES")), // Token expiration time.
            signingCredentials: credentials // Credentials for signing the token.
        );

        // Return the JWT as a string.
        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
