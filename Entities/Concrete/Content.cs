using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Content
    {
        [Key]
        public int ContentID { get; set; } // İçerik ID
        [StringLength(1000)]
        public string ContentValue { get; set; } // içerik Değeri
        public DateTime ContentDate { get; set; } //İçeriğpin Tarihi , içerik ne zaman yazıldı ?

        public int HeadingID { get; set; }
        public virtual Heading Heading { get; set; }

        public int? WriterID { get; set; }
        public virtual Writer Writer { get; set; }
    }
}
