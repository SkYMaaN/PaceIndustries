using Microsoft.AspNetCore.Components.Authorization;
using PaceIndustries.Customer.Data.Entities;
using PaceIndustries.Customer.Models;
using System.Security.Claims;

namespace PaceIndustries.Customer.Services
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly CachedUserData _cachedUserData;

        private ClaimsPrincipal CurrentUser { get; set; }
        public CustomAuthenticationStateProvider(CachedUserData cachedUserData)
        {
            CurrentUser = GetAnonymous();
            _cachedUserData = cachedUserData;
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
            var task = Task.FromResult(new AuthenticationState(CurrentUser));
            return task;
        }

        public Task<AuthenticationState> ChangeUser(string parentKey, string parentCompanyId, List<Contact> userContacts, string username, string email, string role)
        {
            _cachedUserData.ParentKey = parentKey;
            _cachedUserData.ParentCompanyId = parentCompanyId;
            _cachedUserData.Contacts.Clear();
            _cachedUserData.Contacts.AddRange(userContacts);
            _cachedUserData.UserName = username;
            _cachedUserData.Email = email;
            _cachedUserData.Role = role;

            CurrentUser = GetUser(parentKey, username, email, role);
            var task = GetAuthenticationStateAsync();
            NotifyAuthenticationStateChanged(task);
            return task;
        }

        public Task<AuthenticationState> Logout()
        {
            _cachedUserData.ParentKey = String.Empty;
            _cachedUserData.ParentCompanyId = String.Empty;
            _cachedUserData.Contacts.Clear();
            _cachedUserData.UserName = String.Empty;
            _cachedUserData.Email = String.Empty;
            _cachedUserData.Role = String.Empty;

            CurrentUser = GetAnonymous();
            var task = GetAuthenticationStateAsync();
            NotifyAuthenticationStateChanged(task);
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
