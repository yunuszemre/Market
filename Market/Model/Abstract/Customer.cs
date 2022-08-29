using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Model.Abstract
{
    public class Customer
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Adress { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string ImagePath { get; set; }

        public override string ToString()
        {
            return $"{this.FullName} {this.Id} {this.Adress} {this.Gender}";
        }
    }
}
