using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Abstract
{
   public  interface Iauditable
{
    DateTime? createdDate { set; get; }
        [MaxLength(256)]
        string createdBy { set; get; }
        [MaxLength(256)]
        string updatedBy { set; get; }
        DateTime? updatedDate { set; get; }
        [MaxLength(256)]
        string Metakeywork { set; get; }
        [MaxLength(256)]
        string MetaDescription { set; get; }
        [MaxLength(256)]
        bool Status { set; get; }
    }
}
