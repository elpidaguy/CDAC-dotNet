using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace DAL
{
    public static class TraningRepository
    {
        public static List<Student> GetAll()
        {
            List<Student> studList = new List<Student>();
            studList.Add(new Student { Name = "Kaustubh" });
            studList.Add(new Student { Name = "Jason" });
            studList.Add(new Student { Name = "Tom" });
            studList.Add(new Student { Name = "Ben" });
            return studList;

        }
    }
}
