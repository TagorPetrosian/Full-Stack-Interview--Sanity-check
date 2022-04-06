﻿using System.ComponentModel.DataAnnotations;

namespace backend.Dtos
{
    public class CommandUpdateDto
    {
        [MaxLength(100)]    
        [Required]
        public string HowTo { get; set; }
        [Required]
        public string Line { get; set; }
        [Required]
        public string Platform { get; set; }
    }
}
