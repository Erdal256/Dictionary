using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [StringLength(50)]
        public string CetegoryName { get; set; }
        [StringLength(200)]
        public string CetegoryDescription { get; set; } // Kategori Açıklama
        public bool CategoryStatus { get; set; } // Kategori Durum olarak çevrilebilir. durumu aktif veya pasif

        public ICollection<Heading> Headings { get; set; } // ilişki
    }
}
