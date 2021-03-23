using System;

public class Gato: Mamifero // ***Herencia***
{
    public string Pelaje { get; set; } // ***abstraccion****

    public void Maullar()
    {
        Console.WriteLine("Miau miau miau");
    }
}