namespace EspacioCalculadora;

public class Calculadora
{
    private double dato = 0;

    public void Sumar(double termino)
    {
        dato += termino;
    }

    public void Restar(double termino)
    {
        dato -= termino;
    }

    public void Multiplicar(double termino)
    {
        dato *= termino;
    }

    public void Dividir(double termino)
    {
        if (termino != 0)
        {
            dato = dato / termino;
        }
        else
        {
            Console.WriteLine("Error, no se puede dividir en 0");
        }
    }

    public void Limpiar()
    {
        dato = 0;
    }
    
    public double Resultado
    {
        get => dato;
    }
}