namespace OrderManager.Models;

public class Order
{
    public int Id { get; private set; }
    
    public string SenderCity { get; private set; }
    
    public string SenderAddress { get; private set; }
    
    public string RecipientCity { get; private set; }
    
    public string RecipientAddress { get; private set; }
    
    public float WeightKg { get; private set; }
    
    public DateTime PickupDate { get; private set; }

    public Order()
    {
        
    }
}