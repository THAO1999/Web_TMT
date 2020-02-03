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
    [Table("Orders")]
  public  class Order : Auditable
    {
        [Key] // khoa chinh
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        public string CustomerName { set; get; }
        [Required]
        public string CustomerAdress { set; get; }
        [Required]
        public string CustomerEmail { set; get; }
        [Required]
        public string CustomerMessage { set; get; }
        public string CustomerMobile { set; get; }
        
        public DateTime CreateDate { set; get; }
        public string CreatedBy { set; get; }
        public string PaymentMethod { set; get; }
        public string PaymentStatus { set; get; }

        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }

    }
}
