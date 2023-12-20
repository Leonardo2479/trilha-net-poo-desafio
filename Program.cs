using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "(+55) 11 94508-3412", modelo: "Modelo NOKIA", imei: "13579", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Linkedin");

Console.WriteLine("-------------------------------------------------------");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "(+55) 11 21438-0549", modelo: "Modelo IPHONE", imei: "2468", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Nubank");