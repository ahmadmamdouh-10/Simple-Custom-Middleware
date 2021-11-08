using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day8.Controllers
{
    [ApiController]
    //[Route("[controller]/[action]")]
    [Route("Employee")]
    public class EmployeeController : ControllerBase
    {
        List<Employee> EmpList
          = new List<Employee>()
          {
                new Employee{ID=1, Name="Ahmed" , Password= "123456"},
                new Employee{ID=2, Name="Moataz", Password= "123456"}
          };

        [Route("Login")]
        public string Login()
        {
            return "Token Generated";
        }

        [Route("GetData")]
        public string GetData()
        {
            return "This is all data, Thanks!";
        }













        [Route("Get")]
        public string Get()
        {
            return "ITI Sohag";
        }



        [Route("GetByID/{id:int:range(3,500)}/{name:alpha}")]
        public string GetByID(string id, string name)
        {
            return $"ID is {id} and Name is {name} ";
        }


        [Route("GetEmployees")]
        public IEnumerable<Employee> GetEmployees()
        {
            return EmpList;
        }


        [Route("GetEmp")]
        public IActionResult GetEmp(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }
            else
            {
                var emp
             = EmpList.FirstOrDefault(i => i.ID == id);

                return Ok(emp);
            }

        }



    }
}
