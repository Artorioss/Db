using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities
{
    public class Goods: Entity
    {
        public int Id { get; private set; }
        public string name { get; private set; }
        public Model model { get; private set; }

        public Goods(int id, string name, Model model)
        {
            Id = id;
            this.name = name;
            this.model = model;
        }
    }
}
