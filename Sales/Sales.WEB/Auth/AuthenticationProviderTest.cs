using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Sales.WEB.Auth
{
    public class AuthenticationProviderTest : AuthenticationStateProvider
    {
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var anonimous = new ClaimsIdentity();
            var yarenasUser = new ClaimsIdentity(new List<Claim>
            {
            new Claim("FirstName", "Yeison"),
            new Claim("LastName", "Arenas"),
            new Claim(ClaimTypes.Name, "yarenas@yopmail.com"),
            new Claim(ClaimTypes.Role, "Admin")
            },
        authenticationType: "test");
            return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(yarenasUser)));
        }
    }
}
