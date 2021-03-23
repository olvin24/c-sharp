using System;
public abstract class Animal
{
    public string Nombre { get; set; } // *** Abstraccion ***
    public void Caza ()
    {
        Console.WriteLine("Canzando...");

    }

    public void Comer() // *** Abstraccion ***
    {
        Console.WriteLine("Comiendo...");
    }
}