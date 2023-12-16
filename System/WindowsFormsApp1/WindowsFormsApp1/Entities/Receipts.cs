using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities
{
    public class Receipts: Entity
    {
        public int id { get; private set; }
        public Model model { get; private set; }
        public DateTime dateReceipt { get; private set; }
        public int count { get; private set; }
        public Employee employee { get; private set; }

        public Receipts(int id, Model model, DateTime dateReceipt, int count, Employee employee)
        {
            this.id = id;
            this.model = model;
            this.dateReceipt = dateReceipt;
            this.count = count;
            this.employee = employee;
        }

    }
}
