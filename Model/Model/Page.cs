﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    [Table("Pages")]
    public class Page
    {
        [Key] // khoa chinh
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        [MaxLength(256)]
        public string  Name { set; get; }
        
        [Column(TypeName ="varchar")]// kieu dl varchar
        [MaxLength(256)]
        [Required]
        public string Alias { set; get; }
        public string Content { set; get; }
    }
}
