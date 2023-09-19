﻿namespace GetSet.Modelos;
public class Carro
{
    private string Marca;
    private string Nome;
    private int Potencia;

    public Carro(string marca, string nome, int potencia)
    {
        Marca = marca;
        Nome = nome;
        Potencia = potencia;
    }

    public Carro() { }

    public string GetMarca()
    {
        return Marca;
    }

    public void SetMarca(string marca)
    {
        Marca = marca;
    }

    public string GetNome()
    {
        return Nome;
    }

    public int GetPotencia()
    {
        return Potencia;
    }
}
