using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456789", modelo: "Nokia g23", imei: "11123123" , memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n-------------------------\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "98324025", modelo: "Iphone 15 pro", imei: "16534878" , memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");

