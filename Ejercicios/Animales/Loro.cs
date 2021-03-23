using System;
public class Loro: Aves // *** Herencia ***
{
    public bool EsMayor { get; set; }
    public void Hablar() // *** Abstraccion ***
    {
        Console.WriteLine("Hablando...");
    }

    public Loro() // *** Polimorfismo ***
    {
        EsMayor = true;
    }

    public Loro(bool EsMayor) // *** Polimorfismo ***
    {
      Console.WriteLine("...");  
    }
    
}
