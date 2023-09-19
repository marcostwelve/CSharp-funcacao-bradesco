namespace Encapsulamento.Modelos;

public class Mensagem
{
    private String Texto;

    public void Exibir()
    {
        Console.WriteLine(this.Texto);
    }

    public String getTexto()
    {
        return this.Texto;
    }

    public void setTexto(String txt)
    {
        this.Texto = txt;
    }
}
