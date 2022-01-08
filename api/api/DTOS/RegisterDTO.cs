﻿using System.ComponentModel.DataAnnotations;

namespace api.DTOS
{
    public class RegisterDTO
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4)]
        public string Password{ get; set; }
    }
}
