//Neste tópico, veremos como utilizar uma referência ou cópia de um valor, o que dependerá da maneira como você deseja criar a chamada da variável

static void AlterarRef(ref int numero)
{
    numero = numero + 500;
}

static void AlterarOut(int numero)
{
    numero = 0;
    numero = numero + 50;
}

int x = 5;
AlterarRef(ref x);
Console.WriteLine(x);

int y = 8;
AlterarOut(y);
Console.WriteLine(y);