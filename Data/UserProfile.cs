using Microsoft.AspNetCore.Identity;

namespace NettlyMVCWebApp.web.Data
{
    public class UserProfile : IdentityUser
    {
        
        public string? FirstName  { get; set; }
        public string? LastName { get; set; }
        public string? Address {  get; set; }
        public string? Role {  get; set; }   
        public DateTime DateJoined { get; set; }
    }
}
