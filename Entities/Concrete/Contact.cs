using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; } //İletişim ID
        [StringLength(50)]
        public string UserName { get; set; } //Kullanıcı Adı
        [StringLength(50)]
        public string UserMail { get; set; } //Kullanıcı Maili
        [StringLength(50)]
        public string Subject { get; set; } // Konu
        public string Message { get; set; } // Mesaj
    }
}
