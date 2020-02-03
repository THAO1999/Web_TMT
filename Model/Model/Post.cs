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
    [Table("Posts")]
   public  class Post :Auditable
    {
        [Key] // khoa chinh
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        public string Name { set; get; }
        [Column(TypeName = "varchar")]// kieu dl varchar
        [MaxLength(256)]
        [Required]
        public string Alias { set; get; }
        [Required]
        [MaxLength(256)]
        public string Image { set; get; }
        public string Content { set; get; }
        [MaxLength(500)]
        public string Decription { set; get; }
       
        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }

        public virtual IEnumerable<PostTag> PostTags { set; get; }

        [ForeignKey("PostCategoryID")]
        public int PostCategoryID { set; get; }
        public PostCategorie PostCategories { get; set; }
    }
}
