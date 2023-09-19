namespace Delegate.Modelo;

// Agora, falaremos sobre a função delegate. Ela se caracteriza como uma referência para um ou mais métodos,
// a qual é utilizada para a comunicação entre objetos de forma flexível e extensível. Observe o exemplo abaixo onde é criado um delegate no código.
delegate double BinaryNumericOperation(double n1, double n2);
internal class Calculadora
{
    public static double Max(double x, double y)
    {
        if(x > y)
        {
            return x;
        }
        else
        {
            return y;
        }
    }

    public static double Soma(double x, double y)
    {
        return x + y;
    }
}
