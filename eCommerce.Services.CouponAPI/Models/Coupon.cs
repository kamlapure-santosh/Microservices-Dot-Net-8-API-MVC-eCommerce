﻿using System.ComponentModel.DataAnnotations;

namespace eCommerce.Services.CouponAPI.Models
{
    public class Coupon
    {
        [Key]
        public int Couponid { get; set; }
        
        [Required]
        public string? CouponCode { get; set; }
        
        [Required]        
        public double DiscountAmount { get; set; }
        
        public int MinAmount { get; set; }
        
        public DateTime LastUpdated { get; set; }
    }
}
