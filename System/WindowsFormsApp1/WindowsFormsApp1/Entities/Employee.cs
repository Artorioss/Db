using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities
{
    public class Employee: Entity
    {
        public int id { get; private set; }
        public string lastName { get; private set; }
        public string firstName { get; private set; }
        public string surName { get; private set; }
        public JobTitle jobTitle { get; private set; }

        public Employee(int id, string lastName, string firstName, string surName, JobTitle jobTitle)
        {
            this.id = id;
            this.lastName = lastName;
            this.firstName = firstName;
            this.surName = surName;
            this.jobTitle = jobTitle;
        }
    }
}
