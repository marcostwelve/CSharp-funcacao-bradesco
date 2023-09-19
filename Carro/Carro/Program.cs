var carro = new Carro();
carro.Nome = "Hilux";
carro.Marca = "Toyota";
carro.Potencia = 3.1;
Console.WriteLine($"{carro.Nome} {carro.Marca} {carro.Potencia}");

var carro2 = new Carro("Celta", "Chevrolet", 1.0);

Console.WriteLine($"{carro2.Nome} {carro2.Marca} {carro2.Potencia}");
