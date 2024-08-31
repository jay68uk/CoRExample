using System;
using CorExample;
using Spectre.Console;

var handlerA = new OrderLoyaltyDiscountHandler();
var handlerB = new OrderValueHandler();
var handlerC = new OrderDiscountHandler();

handlerA.SetNextHandler(handlerB);
handlerB.SetNextHandler(handlerC);

var request = new OrderRequest()
{
  OrderId = Guid.NewGuid(),
  PromoCode = "ZYX",
  OrderItems = new Dictionary<string, decimal>(){{"Book", 20.55m}, {"Pen", 9.50m}, {"Ruler", 1.00m}, {"Pencil", 0.50m} }
};

AnsiConsole.MarkupLine("[underline bold blue]Handle Request 1[/]");
handlerA.HandleRequest(request);

var request2 = new OrderRequest()
{
  OrderId = Guid.NewGuid(),
  OrderItems = new Dictionary<string, decimal>(){{"Pen", 9.50m}, {"Ruler", 1.00m}, {"Pencil", 0.50m} }
};

Console.WriteLine();
AnsiConsole.MarkupLine("[underline bold blue]Handle Request 2[/]");
handlerA.HandleRequest(request2);

