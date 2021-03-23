using System;
public class Mono : Mamifero // *** Herencia ***


{
 private int Manos { get; set; }  // *** Encapsulamiento ***
 public bool ComeBananas { get; set; }  // *** Abstraccion ***
public bool dormir();



  public void Chilla()  // ** Abstraccion ****
 {
  Console.WriteLine("Uuaa uuaa uuaa");
 }
}