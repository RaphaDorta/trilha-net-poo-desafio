using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia (numero: "123", modelo: "modelo 1", imei: "iiiii", memoria: 64 );
nokia.Ligar();
nokia.InstalarAplicativo("whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "245", modelo: "modelo 2", imei: "ooooo", memoria: 126);
iphone.Ligar();
iphone.InstalarAplicativo("telegram");

