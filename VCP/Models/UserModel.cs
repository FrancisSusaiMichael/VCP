using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VCP.Models
{
    public class UserModel
    { 
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string EmailAddress { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
    }
}