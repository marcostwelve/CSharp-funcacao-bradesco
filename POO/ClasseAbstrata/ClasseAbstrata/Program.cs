//la pode ser do tipo abstrata somente se houver outra classe que a herde, uma vez que esse tipo não pode ser instanciado.

using ClasseAbstrata.Celular;

Xiaomi cel1 = new Xiaomi();
Console.WriteLine(cel1.Tipo());
