using DesafioPOO.Models;

// implementado os testes:
Smartphone iphone = new Iphone("+55 11 91111-1111", "Iphone 15 Pro", 353864162339651, 8);
Console.WriteLine("Listando os modelos de celulares:");
Console.WriteLine($"iPhone:\n Número atual: {iphone.Numero}\n Modelo: {iphone.Modelo}\n IMEI: {iphone.Imei}\n Memória: {iphone.Memoria}");
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Smartphone nokia = new Nokia("+55 11 91234-5678", "Nokia G42", 350693148019233, 6);
Console.WriteLine($"Nokia:\n Número atual: {nokia.Numero}\n Modelo: {nokia.Modelo}\n IMEI: {nokia.Imei}\n Memória: {nokia.Memoria}");
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");

