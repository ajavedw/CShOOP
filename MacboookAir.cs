using System;
// WITHOUT INTERFACE IMPLEMENTATION
/* public class MackbookAir : Laptop 
{

    public override bool TouchScreen => false;
} */

// WITH INTERFACE IMPLEMENTATION

public class MackbookAir : Laptop
{
    public void TurnOff(){
        Console.WriteLine("Turn on ");
    }

    public void TurnOn(){
        Console.WriteLine("Turn off ");
    }

    public void TurnOn(bool accessBIOS){
        if (accessBIOS){
            Console.WriteLine("Accessing BIOS on mac");
        }
        else {
            Console.WriteLine("Not Accessing BIOS on mac");
        }
    }

    public  bool TouchScreen => true;
    string name = "method overriding check";
}