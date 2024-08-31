using Spectre.Console;

namespace CorExample;

public class OrderDiscountHandler : Handler
{
  public override void HandleRequest(OrderRequest orderRequest)
  {
    // Validate promo code
    if (string.IsNullOrEmpty(orderRequest.PromoCode))
    {
      AnsiConsole.MarkupLine("[green bold]OrderDiscountHandler[/] no promo code");
    }
    else
    {
      if (!orderRequest.HasLoyaltyDiscount && !string.IsNullOrEmpty(orderRequest.PromoCode))
      {
        orderRequest.HasPromoDiscount = true;
        AnsiConsole.MarkupLine("[green bold]OrderDiscountHandler[/] apply promo code discount");
      }
      else
      {
        AnsiConsole.MarkupLine("[green bold]OrderDiscountHandler[/] cannot apply promo code when there is a loyalty discount");
      }
    }

    NextHandler?.HandleRequest(orderRequest);
  }
}