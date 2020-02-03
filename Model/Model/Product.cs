using Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Model.Model
{
    [Table("Products")]
  public   class Product : Auditable
    {[Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        public string Name { set; get; }
        public string Alias { set; get; }
       
        public string Image { set; get; }
        public XElement MoreImages { set; get; }

        public decimal Price { set; get; }
        public decimal PromotionPrice { set; get; }
        public int? Wrranty { set; get; }
        public string Decription { set; get; }
        public string Content { set; get; }
        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }

        [ForeignKey("ProductCategoryID")]
        public int ProductCategoryID { set; get; }
        public virtual ProductCategory ProductCategories { set; get; }

       
       
        public IEnumerable<ProductTag> ProductTags { get; set; }
    }
}
