using Kimlik.Models.IdentityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kimlik.Models.Entities
{
    [Table("Messages")]
    public class Message
    {
        [Key]
        public int Id { get; set; }

        public DateTime MessageDate { get; set; }
        [Required]
        public string Content { get; set; }

        public string SenderId { get; set; }//foregn. olarak kulllancaz.string vercez.1 kısmı application user kısmınıda bir kişinin birden çok mesajı vardır diye list koyduk

        [ForeignKey("SenderId")]
        public virtual ApplicationUser Sender { get; set; }


    }
}
