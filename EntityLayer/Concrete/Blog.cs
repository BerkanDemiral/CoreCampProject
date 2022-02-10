using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public string BlogThumbnailImage { get; set; } // bloğun küçük görseli
        public string BlogImage { get; set; } // bloğun büyük görseli
        public DateTime CreateDate { get; set; }
        public bool BlogStatus { get; set; }

        // (1 bloğun 1kategorisi vardır) Bu nedenle o kategorinin ID'si ve Category sınıfı tanımlanır.
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
