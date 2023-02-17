using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDemo
{
    public class SystemAdmin : UserBase
    {
        public decimal Salery;

        public override string EmailAddress {get; set; }
        public override string FirstName {get; set; }
        public override string LastName {get; set; }
        public override string Password {get; set; }
    }
}
