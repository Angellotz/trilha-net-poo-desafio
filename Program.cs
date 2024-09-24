using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("SmartPhone Nokia");
Nokia n1 = new Nokia(numero:"8876-9999", modelo:"modelo NK27", imei:"33444", memoria:"126g");
n1.Ligar();
n1.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

Console.WriteLine("SmartPhone Iphone");
Iphone i1 = new Iphone(numero:"9073-7777", modelo:"Iphone 11", imei:"334574", memoria:"64g");
i1.Ligar();
i1.InstalarAplicativo("Tinder");





//Iphone i1 = new Iphone("777-555");


