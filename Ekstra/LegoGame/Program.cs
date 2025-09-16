

using LegoGame;

Lego objLego = new Lego("blue", 3, 15, 15, true);

Console.WriteLine($"the current position is: {objLego.XPos},{objLego.YPos}");
Console.WriteLine($"The legos color is {objLego.Color}");
Console.WriteLine($"The legos is horizontal: {objLego.OrientaionHorizontal}");


objLego.OrientaionHorizontal = false;
objLego.Right(6);
objLego.Up(6);
Console.WriteLine($"\nthe current position is: {objLego.XPos},{objLego.YPos}");
Console.WriteLine($"The legos is horizontal: {objLego.OrientaionHorizontal}");


objLego.Right(-17);
objLego.Up(-18);
Console.WriteLine($"\nthe current position is: {objLego.XPos},{objLego.YPos}");
Console.WriteLine($"The legos is horizontal: {objLego.OrientaionHorizontal}");