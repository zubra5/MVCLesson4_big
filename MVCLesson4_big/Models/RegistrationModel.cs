using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCLesson4_big.Models
{
    public class RegistrationModel
    {
        public string Login { get; set; }
        public string Pass { get; set; }
        public string PassSec { get; set; }
        public string Email { get; set; }
    }
}