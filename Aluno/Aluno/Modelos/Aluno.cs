class Aluno
{
    public string Nome;
    public int Idade;
    public int Serie;

    public string Retorno()
    {
        return string.Format($"O aluno(a) {Nome} tem {Idade} anos e está na {Serie}ª série");
    }

    public void RetornoConsole()
    {
        Console.WriteLine(Retorno());
    }
}