namespace CorExample;

public abstract class Handler
{
  protected Handler? NextHandler;

  public void SetNextHandler(Handler nextHandler)
  {
    this.NextHandler = nextHandler;
  }

  public abstract void HandleRequest(OrderRequest orderRequest);
}