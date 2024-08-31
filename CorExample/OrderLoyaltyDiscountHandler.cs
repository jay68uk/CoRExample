using Spectre.Console;

namespace CorExample;

public class OrderLoyaltyDiscountHandler : Handler
{
  public override void HandleRequest(OrderRequest orderRequest)
  {
    // Check if customer meets loyalty criteria - would be persistence lookup
    var random = new Random();
    var randomResult = random.Next(2) == 0;
    
    if (randomResult)
    {
      orderRequest.HasLoyaltyDiscount = true;
      AnsiConsole.MarkupLine("[green bold]OrderLoyaltyDiscountHandler[/] customer has loyalty discount.");
    }
    else
    {
      AnsiConsole.MarkupLine("[green bold]OrderLoyaltyDiscountHandler[/] customer does not has loyalty discount.");
    }

    NextHandler?.HandleRequest(orderRequest);
  }
}