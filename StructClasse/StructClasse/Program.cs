using static StructClasse.Modelos.StructClasse;

PontoS ponto = new PontoS { X = 5, Y = 3 };
PontoS ponto2 = ponto; //Copiar através do valor
ponto.X = 3;
Console.WriteLine("Ponto: {0}", ponto.X);
Console.WriteLine("Ponto 2: {0}", ponto2.Y);

PontoC ponto3 = new PontoC { X = 6, Y = 9 };
PontoC ponto4 = ponto3;
ponto3.X = 3;
Console.WriteLine("Ponto 3 = {0}, Ponto 4 = {1}", ponto3.X, ponto4.X);


// Struct: A atribuição é sempre feita por valor, e não por referência.
// Classe: A atribuição é realizada por referência.