using System; 
class Program 
{ 
    static void Main()
    {   
        Console.WriteLine("Numeros pares de 1 até 50 :");

        for (int i = 1; i <= 50; i++) 
        { 
            if (i % 2 == 0)
            {
                Console.WriteLine(i); 
            }
        }
        Console.WriteLine("ACABOUU");
    } 

}
