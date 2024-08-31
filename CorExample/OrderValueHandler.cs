using Spectre.Console;

namespace CorExample;

public class OrderValueHandler : Handler
{
  public override void HandleRequest(OrderRequest orderRequest)
  {
    orderRequest.OrderValue = orderRequest.OrderItems.Sum(s => s.Value);
    if (orderRequest.OrderValue> 30.00m)
    {
      orderRequest.HasGift = true;
      AnsiConsole.MarkupLine("[green bold]OrderValueHandler[/] customer has free gift.");
    }
    else
    {
      AnsiConsole.MarkupLine("[green bold]OrderValueHandler[/] customer does not has free gift.");
    }

    NextHandler?.HandleRequest(orderRequest);
  }
}