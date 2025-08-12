using DesafioPOO.Models;



Nokia nokia = new Nokia("8599446611", "Nokia SE", "123987654", 128);


Iphone iphone = new Iphone("8599332211", "Iphone 12 PRO", "123654987", 256);


nokia.ReceberLigacao();
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

iphone.ReceberLigacao();
iphone.Ligar();
iphone.InstalarAplicativo("Spotify");