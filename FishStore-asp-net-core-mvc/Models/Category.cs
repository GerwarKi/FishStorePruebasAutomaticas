﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FishStore.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Display(Name="Nome da Categoria")]
        [Required]
        public string Name { get; set; }
    }
}
