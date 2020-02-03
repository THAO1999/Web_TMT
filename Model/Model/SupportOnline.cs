using Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    [Table("SupportOnlines")]
 public  class SupportOnline :Auditable
    {
        [Key] // khoa chinh
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // tu tang
        [MaxLength(50)]
        public int ID { set; get; }
        [Required]
        [MaxLength(50)]
        public string Name { set; get; }
        [MaxLength(50)]
        public string Department { set; get; }
        [MaxLength(50)]
        public string Skype { set; get; }
        [MaxLength(50)]
        public string Mobile { set; get; }
        [MaxLength(50)]
        public string Email { set; get; }
        [MaxLength(50)]
        public string Yahoo { set; get; }
        [Required]
        [MaxLength(50)]
        public string FaecBook { set; get; }
    }
}
