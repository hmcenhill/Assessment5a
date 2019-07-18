using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment5a.Models
{
    public class Account
    {
        [MinLength(1)]
        public string name { get; set; }

        [MinLength(1)]
        public string password { get; set; }
    }
}
