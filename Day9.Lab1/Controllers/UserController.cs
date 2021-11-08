using Day9.Lab1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day9.Lab1.Controllers
{
    [ApiController]
    [Route("User")]
    public class UserController
        : ControllerBase
    {
        static List<User> List
           = new List<User>()
           {
                new User{ID=1, UserName="Ahmed" , Password= "123456"},
                new User{ID=2, UserName="Moataz", Password= "123456"},
                new User{ID=3, UserName="Badr", Password= "123456"}
           };

        private readonly ITokenManager tokenManager;
        static ResultViewModel result;

        public UserController(ITokenManager _tokenManager)
        {
           this.tokenManager = _tokenManager;
        }

        [HttpPost]
        [Route("Login/{user}/{pwd}")]
        public ResultViewModel Login(string user, string pwd)
        {
            if (tokenManager.Authenticate(user, pwd))
            {
               var  Token = tokenManager.NewToken();

                result.Data = Token;
                result.Message = "Token Generated Successfully";


                return result;
            }
            else
            {

                result.Data = "";
                result.Message = "Your are not Authorized, Token didn't generate";


                return result;
            }
        }

        [HttpPost]
        [Route("GetData")]
        public ResultViewModel GetData()
        {
            List<User> EmptyList = new List<User>();

            if (result.Message == "Token Generated Successfully")
            {
                result.Data = List;
                return result;
            }
              

            else if (result.Message == "Your are not Authorized, Token didn't generate")
            {

                result.Data = "";
                result.Message = "Your are not Authorized, Token didn't generate";
                return result;
            }
            else
            {
                result.Data = "";
                result.Message = "Your are not Authorized, Token didn't generate";
                return result;
            }
        }
    }
}
