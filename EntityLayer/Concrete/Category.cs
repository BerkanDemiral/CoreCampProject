using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }

        // 1 Kategoride Birden çok blog olabilir(Dropdownlistbox) bu nedenle Blogs listesi içerisinde tanım gerçekleştirilir.
        public List<Blog> Blogs { get; set; }

    }
}
