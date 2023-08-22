namespace ejercicio40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer numero ");
            int num1=int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Los numero de cada uno son 1[+],2[-],3[/],4[*]");
            Console.WriteLine("Elija un signo que quiera entre 1 y 4 ");
            int numerodesignado=int.Parse(Console.ReadLine());
            switch (numerodesignado) 
            {
              case 1:
                    int respuesta = num1 + num2;
                    Console.WriteLine($"la suma entre estos dos numero es : {respuesta}");
                        break;
              case 2:
                       respuesta =num1 - num2;
                    Console.WriteLine($"la resta entre estos dos numero es : {respuesta}");
                        break;
              case 3:
                       respuesta =num1 / num2;
                    Console.WriteLine($"la division entre estos dos numero es : {respuesta}");
                        break;
                default:
                case 4:
                    respuesta =num1 * num2;
                    Console.WriteLine($"la multiplicacion entre estos dos numero es : {respuesta}");
                    break;

            }

        }
    }
}