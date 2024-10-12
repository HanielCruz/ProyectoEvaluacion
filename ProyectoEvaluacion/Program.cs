namespace ProyectoEvaluacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introducir calificacion");
            decimal Calificacion = decimal.Parse(Console.ReadLine());



            if (Calificacion > 70);
            {

                Console.WriteLine("califiacion aprovatoria");

            }

             else if (Calificacion > 50 );
             {
                    Console.WriteLine("Reprobado con derecho a regularizar");
                }
            else (Calificacion < 50 );
            {
                Console.WriteLine("Reprobado con deber a recursar");
            }
            
        }
    }
}

