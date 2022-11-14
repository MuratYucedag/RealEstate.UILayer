using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.EntityLayer.Concrete
{
   public class Address
    {
        [Key]
        public int AddressID { get; set; }
        public string Address1 { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Mail1 { get; set; }
        public string Mail2 { get; set; }
        public string MapLocation { get; set; }
    }
}
