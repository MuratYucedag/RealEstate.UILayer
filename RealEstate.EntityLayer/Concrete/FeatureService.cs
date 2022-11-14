using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.EntityLayer.Concrete
{
    public class FeatureService
    {
        [Key]
        public int FeatureServiceID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageIcon { get; set; }
    }
}
