using Project.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class Company:BaseEntity
    {
        public string Name { get; set; }

        public Decimal Balance { get; set; }

        public CompanyRating Rating { get; set; }






        //Relational Properties

        public virtual AppUser AppUser { get; set; }


    }
}
