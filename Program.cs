using System;

namespace CSharopOOP
{
    class Program
    {
        //https://www.youtube.com/watch?v=JJcNullbl1o&list=PLylgIRlJtHWRqlr1gtx3UgWXIzFS2ms9N&index=4
        //i dont get what he is saying abt dynamic polymorphism at 10:00 which is mwethod overriding
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

            //---FormatException ENCAPSULATION

            LaptopEncaps mackbookAir =  new MackbookAirEncaps();

            LaptopEncaps asusZenbook = new AsusZenbookEncaps();


            mackbookAir.TurnOn();
            asusZenbook.TurnOn();
            //asusZenbook.BootLoader(); gives error
            // why can't I access asusZenbook.BootLoader();  becauise it type is set as LaptopEncaps
            // adn BootLoader() is part of AsusZenbookEncaps not LaptopEncaps


            AsusZenbookEncaps asusZenbook2 = new AsusZenbookEncaps();

            asusZenbook2.BootLoader();


        }
    }

}
