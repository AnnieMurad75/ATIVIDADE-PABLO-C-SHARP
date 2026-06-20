using System; 
class Program 
{ 
    static void Main()
    { 
        Console.WriteLine("Qual é a sua idade?"); 
        int.TryParse(Console.ReadLine(), out int idade);
        Console.WriteLine("Sua idade é : " + idade);  
        
        bool maiorDeIdade = idade >= 18;

        if (maiorDeIdade)
            {
            Console.WriteLine("Voce é maior de idade.");
        }
        else
            {
            Console.WriteLine("Voce é menor de idade.");
        }

    } 

}
