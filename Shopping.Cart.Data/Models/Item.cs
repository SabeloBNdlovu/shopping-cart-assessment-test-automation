namespace Shopping.Cart.Data.Models
{
  public class Item
  {
    public Product? Product { get; set; }
    public int? Quantity { get; set; }

    public Item()
    {
    }
  }
}