using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4.Overloading
{
    //Model
    internal class User
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public Guid SecurityStamp { get; set; }

        public static explicit operator UserViewModel(User user)
        {
            // Mohamed Tarek Ragab  
            string[]? names = user?.FullName?.Split(" ");
            return new UserViewModel
            {
                Id = user.Id,
                Email = user.Email,
                FirstName = names?[0],
                LastName = names?.Length > 1 ? names[1] : null
            };
        }
    }
}
