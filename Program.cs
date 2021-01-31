using System;

namespace CSharopOOP
{
    class Program
    {
        //https://www.youtube.com/watch?v=JJcNullbl1o&list=PLylgIRlJtHWRqlr1gtx3UgWXIzFS2ms9N&index=4
        //I DONT GET WHAT HE IS SAYING ABT DYNAMIC POLYMORPHISM AT 10:00 WHICH IS MWETHOD OVERRIDING
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            /* 
            
            --FOR CLASSES AND POLYMORPHISM
            Laptop mackbookAir =  new MackbookAir();

            Laptop asusZenbook =  new AsusZenbook();

            IAnimal goldenR = new GoldenRetriever();

            mackbookAir.TurnOn();
            mackbookAir.TurnOff();

            asusZenbook.TurnOn();
            asusZenbook.TurnOff();
            goldenR.Speak();
            Console.WriteLine(mackbookAir.TouchScreen);
            Console.WriteLine(asusZenbook.TouchScreen); */

            //--- ENCAPSULATION
            //https://www.youtube.com/watch?v=hXnyzlanD70&list=PLylgIRlJtHWRqlr1gtx3UgWXIzFS2ms9N&index=5
            //ABSTRACTION IS THE CONCEPT WHILE ENCAPSULATION IS THE EXECUTION OF THAT CONCEPT
            LaptopEncaps mackbookAir =  new MackbookAirEncaps();

            LaptopEncaps asusZenbook = new AsusZenbookEncaps();


            mackbookAir.TurnOn();
            asusZenbook.TurnOn();
            //asusZenbook.BootLoader(); gives error
            // WHY CAN'T I ACCESS ASUSZENBOOK.BOOTLOADER();  becauise it type is set as LaptopEncaps
            // adn BootLoader() is part of AsusZenbookEncaps not LaptopEncaps


            AsusZenbookEncaps asusZenbook2 = new AsusZenbookEncaps();

            asusZenbook2.BootLoader();


        }
    }

}
