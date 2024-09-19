using Microsoft.AspNetCore.Components.Authorization;
using PaceIndustries.Models;
using System.Security.Claims;

namespace PaceIndustries.Services
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly UserInfo _userInfo;

        private ClaimsPrincipal CurrentUser { get; set; }
        public CustomAuthenticationStateProvider(UserInfo userInfo)
        {
            this.CurrentUser = this.GetAnonymous();
            this._userInfo = userInfo;
        }

        private ClaimsPrincipal GetAnonymous()
        {
            var identity = new ClaimsIdentity(new[]
            {
            new Claim(ClaimTypes.Sid, "0"),
            new Claim(ClaimTypes.Name, "Anonymous"),
            new Claim(ClaimTypes.Email, "Anonymous"),
            new Claim(ClaimTypes.Role, "Anonymous")
        }, null);
            return new ClaimsPrincipal(identity);
        }

        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var task = Task.FromResult(new AuthenticationState(this.CurrentUser));
            return task;
        }

        public Task<AuthenticationState> ChangeUser(string userId, string companyId, string parentCompanyId, List<string> parentKeys, string username, string email, string role)
        {
            _userInfo.UserId = userId;
            _userInfo.CompanyId = companyId;
            _userInfo.ParentCompanyId = parentCompanyId;
            _userInfo.ParentKeys = parentKeys;
            _userInfo.UserName = username;
            _userInfo.Email = email;
            _userInfo.Role = role;

            this.CurrentUser = this.GetUser(userId, username, email, role);
            var task = this.GetAuthenticationStateAsync();
            this.NotifyAuthenticationStateChanged(task);
            return task;
        }

        public Task<AuthenticationState> Logout()
        {
            this.CurrentUser = this.GetAnonymous();
            var task = this.GetAuthenticationStateAsync();
            this.NotifyAuthenticationStateChanged(task);
            return task;
        }

        private ClaimsPrincipal GetUser(string id, string username, string email, string role)
        {
            var identity = new ClaimsIdentity(new[]
            {
            new Claim(ClaimTypes. Sid, id),
            new Claim(ClaimTypes.Name, username),
            new Claim(ClaimTypes.Email, email),
            new Claim(ClaimTypes.Role, role)
        }, "Authentication type");
            return new ClaimsPrincipal(identity);
        }
    }
}
