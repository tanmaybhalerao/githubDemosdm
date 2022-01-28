using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class Customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string website { get; set; }
        
        public Customer(int id,string name,string website) 
        {
            this.id = id;
            this.name = name;
            this.website = website;
        }

    }
}
