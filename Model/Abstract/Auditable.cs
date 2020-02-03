using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Abstract
{
   public abstract class Auditable : Iauditable
    {
        public DateTime? createdDate { set; get; }
        [MaxLength(256)]
        public string updatedBy { set; get; }
        public DateTime? updatedDate { set; get; }
        [MaxLength(256)]
        public string createdBy { set; get; }
        [MaxLength(256)]
        public string Metakeywork { set; get; }
        [MaxLength(256)]
        public string MetaDescription { set; get; }
        [MaxLength(256)]
        public bool Status { set; get; }
    }
}
