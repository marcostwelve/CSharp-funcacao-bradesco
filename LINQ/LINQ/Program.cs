int[] numeros = new int[] { 4, 5, 7, 8 };

var operacao = numeros.Where(x => x % 2 == 0);
foreach(int numero in operacao)
{
    Console.WriteLine(numero);
}
