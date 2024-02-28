namespace Mango.Web.Models
{
    public class OrderDetailsDto
    {
       
        public int OrderDetailsId { get; set; }
        public int OrderHeaderId { get; set; }
       // public OrderHeader? OrderHeader { get; set; }    per evitare loop infinito!!!!!
        public int ProductId { get; set; }
        public ProductDto? Product { get; set; }
        public int Count { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
    }
}