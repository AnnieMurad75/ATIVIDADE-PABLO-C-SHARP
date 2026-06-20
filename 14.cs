/*using System; 
class Program 
{ 
    static void Main()
    {   
        Console.WriteLine("Digite 10 numeros inteiros para ver qual é o maior :");
        int[] numeros = new int[10];
        int valormaior = 0;
        
        for (int i = 0; i < numeros.Length; i++) 
        { 
            int.TryParse(Console.ReadLine(), out numeros[i]); 
            valormaior = numeros[i] > valormaior ? numeros[i] : valormaior;

        }  
        Console.WriteLine("O maior valor é: " + valormaior);
    } 

}*/