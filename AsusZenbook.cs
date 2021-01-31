using System;

// WITHOUT INTERFACE IMPLEMENTATION

/* public class AsusZenbook : Laptop 
{

    public override bool TouchScreen => true;

   public override void TurnOn(){
        Console.WriteLine("Turn on zenbook");
    }
} */

public class AsusZenbook : Laptop
{
    public void TurnOff(){
        Console.WriteLine("Turn on zen ");
    }

    public void TurnOn(){
        Console.WriteLine("Turning off zenbook");
    }
        public void TurnOn(bool accessBIOS){
        if (accessBIOS){
            Console.WriteLine("Accessing BIOS on asus");
        }
        else {
            Console.WriteLine("Not Accessing BIOS on asus");
        }
    }

    

    public  bool TouchScreen => false;
}