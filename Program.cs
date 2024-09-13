using DesafioPOO.Models;

Console.WriteLine("Smartphone NOKIA");
Nokia nokia = new Nokia("524225555", "G50", "5555555555", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");


Console.WriteLine("\n");


Console.WriteLine("Smartphone IPHONE");
Iphone iphone = new Iphone("5244823399", "ZP52", "66666666666", 124);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Tigrinho");