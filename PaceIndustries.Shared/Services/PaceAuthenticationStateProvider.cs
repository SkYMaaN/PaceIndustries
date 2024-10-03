using Microsoft.AspNetCore.Components.Authorization;
using PaceIndustries.Shared.Data.Entities;
using PaceIndustries.Shared.Models;
using System.Security.Claims;

namespace PaceIndustries.Shared.Services
{
    public class PaceAuthenticationStateProvider : AuthenticationStateProvider
    {
        /// <summary>
        /// Contains information about authenticated user ( supplier, customer, administrator )
        /// </summary>
        private readonly CachedUserData _cachedUserData;

        private ClaimsPrincipal CurrentUser { get; set; }

        public PaceAuthenticationStateProvider(CachedUserData cachedUserData)
        {
            CurrentUser = CreateAnonymousUser();
            _cachedUserData = cachedUserData;
        }

        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var task = Task.FromResult(new AuthenticationState(CurrentUser));
            return task;
        }

        public Task<AuthenticationState> LoginAsUser(string parentKey, string parentCompanyId, List<Contact> userContacts, string username, string email, string role)
        {
            _cachedUserData.ParentKey = parentKey;
            _cachedUserData.ParentCompanyId = parentCompanyId;
            _cachedUserData.Contacts.Clear();
            _cachedUserData.Contacts.AddRange(userContacts);
            _cachedUserData.UserName = username;
            _cachedUserData.Email = email;
            _cachedUserData.Role = role;

            CurrentUser = CreateUser(parentKey, username, email, role);

            var task = GetAuthenticationStateAsync();
            NotifyAuthenticationStateChanged(task);
            return task;
        }

        public Task<AuthenticationState> LoginAsPreUser(string parentKey, string username, string email, string role)
        {
            _cachedUserData.ParentKey = parentKey;
            _cachedUserData.ParentCompanyId = String.Empty;
            
            _cachedUserData.UserName = username;
            _cachedUserData.Email = email;
            _cachedUserData.Role = role;

            CurrentUser = CreatePreUser(parentKey, username, email, role);

            var task = GetAuthenticationStateAsync();
            NotifyAuthenticationStateChanged(task);
            return task;
        }

        public Task<AuthenticationState> Logout()
        {
            _cachedUserData.ParentKey = string.Empty;
            _cachedUserData.ParentCompanyId = string.Empty;
            _cachedUserData.Contacts.Clear();
            _cachedUserData.UserName = string.Empty;
            _cachedUserData.Email = string.Empty;
            _cachedUserData.Role = string.Empty;

            CurrentUser = CreateAnonymousUser();

            var task = GetAuthenticationStateAsync();
            NotifyAuthenticationStateChanged(task);
            return task;
        }

        private ClaimsPrincipal CreateUser(string id, string username, string email, string role)
        {
            var identity = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Sid, id),
                new Claim(ClaimTypes.Name, username),
                new Claim(ClaimTypes.Email, email),
                new Claim(ClaimTypes.Role, role)
            }, 
            "Authentication type");

            return new ClaimsPrincipal(identity);
        }

        private ClaimsPrincipal CreatePreUser(string parentKey, string username, string email, string role)
        {
            var identity = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Sid, parentKey),
                new Claim(ClaimTypes.Name, username),
                new Claim(ClaimTypes.Email, email),
                new Claim(ClaimTypes.Role, role)
            },
            "Authentication type");

            return new ClaimsPrincipal(identity);
        }

        private ClaimsPrincipal CreateAnonymousUser()
        {
            var identity = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Sid, "0"),
                new Claim(ClaimTypes.Name, "Anonymous"),
                new Claim(ClaimTypes.Email, "Anonymous"),
                new Claim(ClaimTypes.Role, "Anonymous")
            },
            null);

            return new ClaimsPrincipal(identity);
        }
    }
}
