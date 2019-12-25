using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using DAL;

namespace BLL
{
    public class TrainingManager
    {
        public List<Student> GetAllStudents()
        {
            List<Student> studList = new List<Student>();

            studList = TraningRepository.GetAll();

            return studList;
        }
    }
}
