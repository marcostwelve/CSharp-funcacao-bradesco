// LAMBDA
// Função Action: Tipo de função que não tem retorno.
// Função Func: Tipo de função que apresenta retorno.
Action apresentaConsole = () =>
{
    Console.WriteLine("Funções e métodos");
};

apresentaConsole();

Func<int> sorteio = () =>
{
    Random random = new Random();
    return random.Next(1, 100);
};

Console.WriteLine(sorteio());
