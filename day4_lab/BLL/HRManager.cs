using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BOL;

namespace BLL
{
    public class HRManager
    {
        public List<Employee> GetAllEmployees()
        {
            List<Employee> empList = new List<Employee>();

            empList = HRRepository.GetAll();

            return empList;
        }

        public Employee GetEmployee(int id)
        {
            return HRRepository.Get(id);
        }

    }
}
