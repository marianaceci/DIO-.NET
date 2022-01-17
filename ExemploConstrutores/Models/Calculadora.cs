namespace ExemploConstrutores.Models
{
    public class Calculadora
    {
        //4. DELEGATE
            /*
            public static void Somar(int x, int y)
            {
                System.Console.WriteLine($"Adição: {x + y}");
            }
        
            public static void Subtrair(int x, int y)
            {
                System.Console.WriteLine($"Subtração: {x - y}");
            }
            */


        //5. EVENTOS
            // Delegate:
            public delegate void DelegateCalculadora();

            // Evento:
            public static event DelegateCalculadora EventoCalculadora;

            public static void Somar(int x, int y)
            {
                if (EventoCalculadora != null)
                {
                    System.Console.WriteLine($"Adição: {x + y}");
                    EventoCalculadora();
                }
                else
                {
                    System.Console.WriteLine("Nenhum inscrito");
                }

            }
        
            public static void Subtrair(int x, int y)
            {
                System.Console.WriteLine($"Subtração: {x - y}");
            }
    }
}