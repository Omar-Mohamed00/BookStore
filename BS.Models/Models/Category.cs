﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BS.Models.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 100)]
        public int DispalyOrder { get; set; }
    }
}
