using System;

public abstract class Mamifero: Animal // *** Herencia ***
{
    public int Patas { get; set; } // *** Abstraccion ***

    public void Caminar() // ***Abtraccion *** 

    {
        Console.WriteLine("Caminando...");
    }
}