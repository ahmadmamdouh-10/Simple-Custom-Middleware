using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day9.Lab1.Models
{
    public class TokenManager
        : ITokenManager
    {
        private List<Token> listTokens;

        public TokenManager()
        {
            listTokens = new List<Token>();
        }
        public bool Authenticate(string userName, string password)
        {
            if (!string.IsNullOrWhiteSpace(userName) &&
                !string.IsNullOrWhiteSpace(password) &&
                userName.ToLower() == "admin" &&
                password == "password")
                return true;
            else
                return false;
        }

        public Token NewToken()
        {
            var token = new Token
            {
                Value = Guid.NewGuid().ToString(),
                ExpiryDate = DateTime.Now.AddMinutes(1)
            };
            listTokens.Add(token);
            return token;
        }

        public bool VerifyToken(string _token)
        {
            if (listTokens.Any(token => token.Value == _token
             && token.ExpiryDate > DateTime.Now))
            {
                return true;
            }
            return false;
        }
    }
}
