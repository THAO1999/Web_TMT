using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    [Table("ProductCategories")]
  public  class PostCategorie
    {
        [Key] // khoa chinh
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        public string Alias { set; get; }
        public string Decription { set; get; }
        public int ParentID { set; get; }
        public int? DisplayOrder { set; get; }
        public string Image { set; get; }
        [Required]
        public bool? HomeFlag { set; get; }

        public IEnumerable<Post> Posts { get; set; }
        
    }
}
