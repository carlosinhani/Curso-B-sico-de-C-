using System;

class Program {
  public static void Main (string[] args) {
    int n1 = 3;
    double n2 = 3.4;
    string s1 = "Carlos Rodrigo";
    char c1 = '@';
    Console.WriteLine($"{n1} + {n2} + {s1} + {c1}");
    double n3 = n1 + n2;
    Console.WriteLine($"A soma é {n3:F4}.");
    n3 += 5;
    Console.WriteLine($"A nova soma é {n3:F4}.");
    bool ehPar = (n1 % 2 == 0);
    if (!ehPar){
      Console.WriteLine("O número é ímpar");
    }
    else{
      Console.WriteLine("O número é par");
    }
    switch (n1){
      case 1: 
        Console.WriteLine("O Valor é 1.");
        break;
      case 2: 
        Console.WriteLine("O Valor é 2.");
        break;
      case 3: 
        Console.WriteLine("O Valor é 3.");
        break;
      case 4: 
        Console.WriteLine("O Valor é 4.");
        break;
      default: 
        Console.WriteLine("O valor não está entre 1 e 4.");
        break;
    }

    int i = 0;
    while(i < 10){
      Console.WriteLine($"Iteração {i}");
      if (i == 5) {
        break;
      }
      i++;
    }
    Console.WriteLine("Repetição finalizada."); 
    
    for (int j=0; j< 10; j++) {
      if (j == 5) {
        continue;
      }
      Console.WriteLine($"Iteração {j}.");
    }
    Console.WriteLine("Repetição finalizada."); 
    i = 10;
     do
     {
      i--;
      if (i == 5) {
        continue;
      }
      Console.WriteLine($"Iteração {i}");
     } while(i > 0);
    }
  }
