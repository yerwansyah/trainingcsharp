﻿using System.ComponentModel.DataAnnotations;

namespace PaymentApi.Models.DTO.Requests
{
    public class TokenRequest
    {
        [Required]
        public string Token { get; set; }

        [Required]
        public string RefreshToken { get; set; }
    }
}
