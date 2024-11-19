internal class Program
{
    private static void Main(string[] args)
    {
        calcularArea();
    }

    static void calcularArea()
    {
        double Base = 0;
        double altura = 0;
        double limiteArea = 20;
        int contador = 0;
        double area = 0;
        string valor =string.Empty;
        int cantidadElementos = 0;

        Console.WriteLine("Introduzca cantidad de dimensiones a calcular");
        cantidadElementos = Convert.ToInt32 (Console.ReadLine());

        for (int i=1; i<= cantidadElementos; i++)
        {
            Console.WriteLine($"Ingrese las bases del triangulo {i}");
            valor = Console.ReadLine();

            if (double.TryParse(valor, out Base))
            {
                area = (Base * altura)/2;
                if (area > limiteArea)
                {
                    contador++;
                    Console.WriteLine($"Triangulo con base {Base} y altura {altura} tiene un area de{area}, que excede el limite");
                }
            }
            else
            {
                Console.WriteLine("valores incorrectos");
            }
        }
        Console.WriteLine($"cnatidad de triangulos cuya area excede {limiteArea}:{contador}");
    }

}