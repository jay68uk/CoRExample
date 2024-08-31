namespace CorExample;

public class OrderRequest
{
  public Guid OrderId { get; set; }
  public decimal OrderValue { get; set; }
  public string PromoCode { get; set; } = string.Empty;
  public bool HasPromoDiscount { get; set; } = false;
  public bool HasLoyaltyDiscount { get; set; } = false;
  public bool HasGift { get; set; } = false;
  public Dictionary<string, decimal> OrderItems { get; set; }   = new();
}