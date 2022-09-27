using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "198765", modelo: "ModeloN1", imei: "ARCB*#NF(#*%84293", memoria: 16);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone(numero: "34862618", modelo: "ModeloIPH1", imei: "FRGT423*#NF423(#*%84293", memoria: 32);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facetime");