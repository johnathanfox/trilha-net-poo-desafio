using DesafioPOO.Models;

// Bloco de código para testar a classe Nokia

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456789", modelo: "Nokia g23", imei: "11123123" , memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n-------------------------\n");

// Bloco de código para testar a classe Iphone

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "98324025", modelo: "Iphone 15 pro", imei: "16534878" , memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");

