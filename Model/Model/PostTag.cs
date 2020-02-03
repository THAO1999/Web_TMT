using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    [Table("PostTags")]
   public  class PostTag
    {
        [Key] // khoa chinh
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PostID { set; get; }
        [Key] // khoa chinh
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(TypeName ="varchar")]
        [MaxLength(50)]
        public string TagID { set; get; }


        [ForeignKey("PostID")]       
        public virtual Post Posts { set; get; }

        [ForeignKey("TagID")]
        public virtual Tag Tags { set; get; }
    }
}
