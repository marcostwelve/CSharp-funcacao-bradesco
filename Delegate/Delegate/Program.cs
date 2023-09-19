using Delegate.Modelo;

double a = 10;
double b = 30;

BinaryNumericOperation operacao = Calculadora.Soma;

Console.WriteLine(operacao(a, b));
