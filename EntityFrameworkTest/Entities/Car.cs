using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTest.Entities
{
    public class Car
    {
        public int CarID { get; set; }
        public string Brand { get; set; }
        public Driver PreviousDriver { get; set; }
        public Driver CurrentDriver { get; set; }
    }
}
