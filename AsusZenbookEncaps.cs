using System;

// WITHOUT INTERFACE IMPLEMENTATION

/* public class AsusZenbook : Laptop 
{

    public override bool TouchScreen => true;

   public override void TurnOn(){
        Console.WriteLine("Turn on zenbook");
    }
} */

public class AsusZenbookEncaps : LaptopEncaps
{

    public override void TurnOn()
    {
        Console.WriteLine("Turning on zenbook");
        base.PowerOnSelfTest();
        this.BIOSROM();
        this.OSConfig();
        this.Security();
        this.BootLoader();
    }

    private void BIOSROM()
    {
        Console.WriteLine("BIOS  ROM Process");
    }
    private void BootLoader()
    {
        Console.WriteLine("Bootloader");
    }

    private void OSConfig()
    {
        Console.WriteLine("Osconfig loading");
    }
    private void Security()
    {
        Console.WriteLine("Security is a Process");
    }
}