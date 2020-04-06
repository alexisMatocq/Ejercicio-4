using System;

class MainClass {
  public static void Main (string[] args) {

    string R1, R2, R3 ;
    int N1, N2, N3 ;

    Console.WriteLine ("Ingrese tres numeros:");
    R1 = Console.ReadLine();
    R2 = Console.ReadLine();
    R3 = Console.ReadLine();

    N1 = int.Parse(R1);
    N2 = int.Parse(R2);
    N3 = int.Parse(R3);


  Console.WriteLine("primer numero:  "+N1);
  Console.WriteLine("segundo numero: "+N2);
  Console.WriteLine("tercer numero:  "+N3);

  if((N2<N1) && (N1<N3))
  {Console.WriteLine ("el numero intermedio es: " +N1);}
  if((N2>N1) && (N1>N3))
  {Console.WriteLine ("el numero intermedio es: " +N1);}


  if((N1<N2) && (N2<N3))
  {Console.WriteLine ("el numero intermedio es: " +N2);}
  if((N1>N2) && (N2>N3))
  {Console.WriteLine ("el numero intermedio es: " +N2);}


  if((N1<N3) && (N3<N2))
  {Console.WriteLine ("el numero intermedio es: " +N3);}
  if((N1>N3) && (N3>N2))
  {Console.WriteLine ("el numero intermedio es: " +N3);}

  }
}
