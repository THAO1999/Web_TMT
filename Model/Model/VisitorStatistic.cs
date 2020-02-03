using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    [Table("VisitorStatistics")]
   public  class VisitorStatistic
    {
        [Key] // khoa chinh
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { set; get; }
        [Required]
        public DateTime VisiteDate { set; get; }
         public string IPAdress { set; get; }
    }
}
