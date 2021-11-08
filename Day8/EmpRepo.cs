using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day8
{
    public class EmpRepo
    {
        static List<Employee> list;
          
        public EmpRepo()
        {
            list = new List<Employee>()
                        {
                new Employee{ID=1, Name="Sohag"}
                        };
        }
    }
}
