using System;
class Program
{
    static void Main(string[] args)
    {
        // Definir los sabores de los dulces
        string[] sabores = { "Limon", "naranja", "sandia" };

        //Pedir al usuario que ingrese el total de dulces
        Console.WriteLine("Ingrese el total de dulces:");
        int totalDulces = int.Parse(Console.ReadLine());

        //Inicializar contadores para cada sabor 
        int dulcesLimon = 0;
        int dulcesNaranjas = 0;
        int dulcesSandia = 0;

        //Generar aleatoriamente el sabor de cada dulce
        Random rnd = new Random();
        for (int i = 0; i < totalDulces; i++)
        {
            int indiceSabor = rnd.Next(0, 3); // Genera un numero aleatorio entre 0 y 2
            string sabor = sabores[indiceSabor];

            //Incrementar el contador del sabor correspondiente
            switch (sabor)
            {
                case "Limon":
                    dulcesLimon++;
                    break;
                case "naranja":
                    dulcesNaranjas++;
                    break;
                case "sandia":
                    dulcesSandia++;
                    break;
            }
        }

        //Mostrar los resultados 
        Console.WriteLine("Resultados:");
        Console.WriteLine("Dulces de limon: " + dulcesLimon);
        Console.WriteLine("Dulces de naranja: " + dulcesNaranjas);
        Console.WriteLine("Dulces de sandia: " + dulcesSandia);
        Console.ReadLine(); // Para que la consola no se cierre inmediatamente
    }
}









