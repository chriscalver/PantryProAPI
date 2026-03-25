namespace PantryProApi.Models
{
    public class Pantry
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int LocationId { get; set; }
       
        public int? CategoryId { get; set; }
         public string? Size { get; set; }
        
        public int? IsActive { get; set; } 
       
        public DateTime? LastPurchase { get; set; }
        public DateTime? LastUpdated { get; set; }
        public Boolean? IsHot { get; set; }
        public string? Barcode { get; set; } // New property to store a barcode
        public int? Quantity { get; set; } // New property to store quantity
    }
}
