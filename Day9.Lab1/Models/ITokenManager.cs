using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day9.Lab1.Models
{
    public interface ITokenManager
    {
        bool Authenticate(string userName, string password);
        Token NewToken();
        bool VerifyToken(string _token);
    }
}

