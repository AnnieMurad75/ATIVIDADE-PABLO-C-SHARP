/* using System; 
class Program 
{ 
    static void Main()
    {   
        Console.WriteLine("Digite 5 numeros :");
        int[] numeros = new int[5]; 
        int Soma = 0;

        for (int i = 0; i < numeros.Length; i++) 
        { 
            int.TryParse(Console.ReadLine(), out numeros[i]); 
            Soma += numeros[i];
        }   
        Console.WriteLine("Total : " + Soma);
    } 

}*/