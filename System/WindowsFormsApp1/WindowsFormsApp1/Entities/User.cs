using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities
{
    public class User: Entity
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Password { get; private set; }
        public Employee employee { get; private set; }

        public User(int id, string name, string password, Employee employee)
        {
            Id = id;
            Name = name;
            Password = password;
            this.employee = employee;
        }
    }
}
