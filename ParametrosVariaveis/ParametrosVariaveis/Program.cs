static void Despedida(params string[] alunos)
{
    foreach(string aluno in alunos)
    {
        Console.WriteLine("Tchau {0}, até a próxima aula", aluno);
    }
}

Despedida("Mariana", "Paola", "Maurício");