using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Heading
    {
        [Key]
        public int HeadingID { get; set; } //Başlık ID
        [StringLength(50)]
        public string HeadingName { get; set; } // Başlık Adı
        public DateTime HeadingDate { get; set; } // Başlığın Oluşturulma tarihi
        public bool HeadingStatus { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category{ get; set; } // ilgili sınıftan, ilgili değer

        public int WriterID { get; set; }
        public virtual Writer Writer { get; set; }

        public ICollection<Content> Contents { get; set; }
    }
}
