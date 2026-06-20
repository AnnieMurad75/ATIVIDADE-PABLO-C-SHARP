using System; 
class Program 
{ 
    static void Main()
    { 
        Console.WriteLine("Informe sua nota e veja seus status");
        int.TryParse(Console.ReadLine(), out int nota);

        if (nota <= 30)
            {
                Console.WriteLine("Você está reprovado.");
            }
        else if (nota <= 50)
            {
                Console.WriteLine("Você está de recuperação.");
            }
        else
            {
                Console.WriteLine("Você está aprovado.");
            }

    } 

}
