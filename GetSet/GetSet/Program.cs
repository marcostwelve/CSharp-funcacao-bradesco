using GetSet.Modelos;

Carro carro1 = new Carro();
carro1.SetMarca("Fiat");

Console.WriteLine(carro1.GetMarca());

Carro carro2 = new Carro("Renault", "Clio", 2);

Console.WriteLine($"{carro2.GetNome()} {carro2.GetMarca()} {carro2.GetPotencia()}");
