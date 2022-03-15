using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public  class GoodsStockMarket:BaseEntity
    {
        public  string Name { get; set; }

        public  decimal SellPrice { get; set; }

        public  int  Unit { get; set; }


    }
}
