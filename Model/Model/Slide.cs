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
    [Table("Slides")]
  public  class Slide :Auditable
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [MaxLength(50)]
        public int ID { set; get; }
        [Required]
        [MaxLength(256)]
        public string Name { set; get; }
        [MaxLength(500)]
        public string Description { set; get; }
        [MaxLength(256)]
        public string Image { set; get; }
        [MaxLength(256)]
        public string URL { set; get; }
        public string DisplayOrder { set; get; }
        
    }
}
