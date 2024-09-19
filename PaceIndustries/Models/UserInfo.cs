namespace PaceIndustries.Models
{
    public class UserInfo
    {
        /// <summary>
        /// Supplier or customer id
        /// </summary>
        public string UserId { get; set; }

        public string CompanyId { get; set; }
        public string ParentCompanyId { get; set; }

        public List<string> ParentKeys { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string Role { get; set; }
    }
}
