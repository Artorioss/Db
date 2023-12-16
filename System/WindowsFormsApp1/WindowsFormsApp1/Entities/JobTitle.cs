using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities
{
    public class JobTitle: Entity
    {
        public int id { get; private set; }
        public string name { get; private set; }

        public JobTitle(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
