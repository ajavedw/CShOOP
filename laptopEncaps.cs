using System;

public abstract class LaptopEncaps

{
    public abstract void TurnOn();

    protected void PowerOnSelfTest()
    {
        Console.WriteLine("Checking processors...");
        Console.WriteLine("Checking System memory");
        Console.WriteLine("Checking network");
        Console.WriteLine("Checking USB");
        Console.WriteLine("Checking Bluetooth");


    }
}