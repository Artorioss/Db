using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WindowsFormsApp1.Entities
{
    public class Model: Entity
    {
        public int id { get; private set; }
        public string name { get; private set; }
        public decimal cost { get; private set; }

        public Model(int id, string name, decimal cost)
        {
            this.id = id;
            this.name = name;
            this.cost = cost;
        }
    }
}
