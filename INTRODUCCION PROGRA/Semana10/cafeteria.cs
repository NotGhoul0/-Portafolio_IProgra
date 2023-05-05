using System;
class cafetera
{
    int codigo;
    int capacidad, disponibles;
    bool lleno;
    public void hacerCafe()
    {
        lleno = true;
        disponibles = capacidad;
    }
    public void servirTaza(int cantTazas)
    {
        if (disponibles >= cantTazas)
        {
            disponibles = disponibles - cantTazas;
        }
        else
        {
            Console.WriteLine("No existen tazas disponibles");
        }
    }
    public double obtenerPorsentaje()
    {
        double porsentaje = ((double)disponibles / capacidad) * 100;
        return porsentaje;
    }
    public void mostrarEstado()
    {
        string texto = codigo + " capacidad: " + capacidad + " tazas servidas: " + (capacidad - disponibles) +
            "pocentaje: " + obtenerPorsentaje() + "%";
        Console.WriteLine(texto);
    }
    public cafetera(int elcodigo, int lacapacidad)
    {
        codigo = elcodigo;
        capacidad = lacapacidad;
        lleno = false;
        disponibles = 0;
    }
    public static void Main()
    {
        Console.WriteLine("Ingrese capacidad de cafetera");
        int cap = Convert.ToInt32(Console.ReadLine());
        string opcion = "";
        cafetera cafe = new cafetera(1, cap);


        cafe.hacerCafe();
        do
        {
            Console.WriteLine("Cuantea tazas desea servir?");
            int tz = Convert.ToInt32(Console.ReadLine());
            cafe.servirTaza(tz);
            cafe.mostrarEstado();

            Console.WriteLine("Desea ingresar mas tazas? s/n");
            opcion = Console.ReadLine().ToLower();
        } while (opcion == "s");

    }
}