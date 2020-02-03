using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Model.Model
{
    [Table("Footers")] // map theo table
    public class Footer
    {
        [Key] // khoa chinh
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [MaxLength(50)]
        public string ID { set; get; }
        [Required] // yeu cau bat buoc
        public string Content { set; get; }

    }
}
