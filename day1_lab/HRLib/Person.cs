using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public class Person
    {
        private String firstName, lastName, email, location;
        private DateTime birthDate;

        public Person()
        {

        }

        public Person(String firstName, String lastName, String email, String location, DateTime birthDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.location = location;
            this.birthDate = birthDate;
        }

        ~Person()
        {

        }

        public override string ToString()
        {
            //return base.ToString();
            return "FirstName: " + this.firstName + ", LastName: " + this.lastName + ", Email: " + this.email + ", Location: " + this.location + ", BirthDate: " + this.birthDate +"\n";
        }
    }
}
