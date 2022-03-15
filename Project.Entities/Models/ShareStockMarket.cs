using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public  class ShareStockMarket:BaseEntity
    {
        public string Name { get; set; }

        public decimal SharePrice { get; set; }

        public int ShareUnit { get; set; }


        //Relational Properties
    }
}
