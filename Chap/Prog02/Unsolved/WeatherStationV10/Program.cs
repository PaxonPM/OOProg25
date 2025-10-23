Barometer objBarometer1 = new Barometer();
objBarometer1.Pressure = 940;
objBarometer1.HandlePressure();

Console.WriteLine($"The weather pressure is {objBarometer1.Pressure} and the description is {objBarometer1.WeatherDescription}");
objBarometer1.Pressure = 995;
objBarometer1.HandlePressure();
Console.WriteLine($"The weather pressure is {objBarometer1.Pressure} and the description is {objBarometer1.WeatherDescription}");
objBarometer1.Pressure = 1010;
objBarometer1.HandlePressure();
Console.WriteLine($"The weather pressure is {objBarometer1.Pressure} and the description is {objBarometer1.WeatherDescription}");
objBarometer1.Pressure = 1025;
objBarometer1.HandlePressure();
Console.WriteLine($"The weather pressure is {objBarometer1.Pressure} and the description is {objBarometer1.WeatherDescription}");
objBarometer1.Pressure = 1060;
objBarometer1.HandlePressure();
Console.WriteLine($"The weather pressure is {objBarometer1.Pressure} and the description is {objBarometer1.WeatherDescription}");
