using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.v1.Core.Model
{
    public class User : BaseEntity
    {
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; } //encoded form
        public bool IsActive { get; set; }
        public DateTime? BlockDate { get; set; }


    }
}
