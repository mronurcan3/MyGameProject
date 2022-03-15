using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class GameProfile:BaseEntity
    {
        public Decimal UserBalance { get; set; }



        //Relational Properties


        public virtual AppUser AppUser { get; set; }

    }
}
