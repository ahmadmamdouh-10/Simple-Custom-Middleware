using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day9.Lab1.Models
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        Token token;
    }
}
