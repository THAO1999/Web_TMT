using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    [Table("Tags")]
    public class Tag
    {
        [Key] // khoa chinh
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [MaxLength(50)]
        public string ID { set; get; }
        [Required]
        public string Name { set; get; }
        public string Type { set; get; }

        
        public virtual IEnumerable<PostTag> PostTags { set; get; }
        public virtual IEnumerable<ProductTag> ProductTags { set; get; }
    }
}
