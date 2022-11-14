using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.EntityLayer.Concrete
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductType { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductTitle { get; set; }
        public string ProductSize { get; set; }
    }
}
