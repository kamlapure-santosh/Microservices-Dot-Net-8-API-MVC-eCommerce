namespace eCommerce.Web.Models
{
    public class CouponDto
    {
        public int Couponid { get; set; }
        public string? CouponCode { get; set; }
        public double DiscountAmount { get; set; }
        public int MinAmount { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
