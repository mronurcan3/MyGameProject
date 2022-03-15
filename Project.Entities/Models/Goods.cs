using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class Goods:BaseEntity
    {
        public string Name { get; set; }

        public Decimal SalePrice { get; set; }

        public Decimal ProductionPrice { get; set; }




        //Relational Properties
    }
}
