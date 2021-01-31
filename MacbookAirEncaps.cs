using System;
// WITHOUT INTERFACE IMPLEMENTATION
/* public class MackbookAir : Laptop 
{

    public override bool TouchScreen => false;
} */

// WITH INTERFACE IMPLEMENTATION

public class MackbookAirEncaps : LaptopEncaps
{

    public override void TurnOn()
    {
        Console.WriteLine("Turning on macbook");
        this.FindBooterFile();
        this.BootROMLoaded();
        this.BootROMRunning();
        this.LoadKernel();
         Console.WriteLine("------");
    }

    private void BootROMLoaded()
    {
        Console.WriteLine("BIOS  ROM loaded");
    }
    private void BootROMRunning()
    {
        Console.WriteLine("Bootrom running");
    }

    private void FindBooterFile()
    {
        Console.WriteLine("Finding booter file");
    }
    private void LoadKernel()
    {
        Console.WriteLine("Booter loads kernel");
    }
}