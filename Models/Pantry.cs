namespace PantryProApi.Models
{
    public class Pantry
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int LocationId { get; set; }
        public Location? Location { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public string? ImageUrl { get; set; }
        public string? ImageName { get; set; }
        public string? Size { get; set; }
        public string? ExtraStrOne { get; set; }
        public string? ExtraStrTwo { get; set; }
        public int? IsActive { get; set; } 
        public int? ExtraIntOne { get; set; }
        public int? ExtraIntTwo { get; set; }
        public DateTime? LastPurchase { get; set; }
        public DateTime? LastUpdated { get; set; }
        public Boolean? IsHot { get; set; }
    }
}
