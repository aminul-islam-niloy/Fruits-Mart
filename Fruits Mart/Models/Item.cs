namespace Fruits_Mart.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set;}

        public double Price { get; set; }
        public string ImageUrl { get; set; }  
        
        public int Quantity { get; set; }   


    }
}
