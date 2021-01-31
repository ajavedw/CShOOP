using System;


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
    public void BootLoader()
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