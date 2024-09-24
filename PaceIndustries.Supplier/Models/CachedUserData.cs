﻿using PaceIndustries.Supplier.Data.Entities;

namespace PaceIndustries.Supplier.Models
{
    public class CachedUserData
    {
        public string ParentKey { get; set; }

        public string ParentCompanyId { get; set; }
        public List<Contact> Contacts { get; set; } = new();

        public string UserName { get; set; }

        public string Email { get; set; }

        public string Role { get; set; }
    }
}