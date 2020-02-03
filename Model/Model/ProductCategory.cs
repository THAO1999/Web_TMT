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
    [Table("ProductCategories")]
   public class ProductCategory :Auditable
    {
        [Key] // khoa chinh
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        public string Alias { set; get; }
        public string Decription { set; get; }
        [Required]
        public int ParentID { set; get; }
        public int? DisplayOrder { set; get; }
        public string Image { set; get; }
        [Required]
        public bool? HomeFlag { set; get; }
       

        public virtual IEnumerable<Product> Products { set; get; }    
        public virtual IEnumerable<Post> Posts { get; set; }
        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }

    }
}
