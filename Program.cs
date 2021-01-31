using System;

namespace CSharopOOP
{
    class Program
    {
        //https://www.youtube.com/watch?v=JJcNullbl1o&list=PLylgIRlJtHWRqlr1gtx3UgWXIzFS2ms9N&index=4
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Laptop mackbookAir =  new MackbookAir();

            Laptop asusZenbook =  new AsusZenbook();

            IAnimal goldenR = new GoldenRetriever();

            mackbookAir.TurnOn();
            mackbookAir.TurnOff();

            asusZenbook.TurnOn();
            asusZenbook.TurnOff();
            goldenR.Speak();
            Console.WriteLine(mackbookAir.TouchScreen);
            Console.WriteLine(asusZenbook.TouchScreen);

        }
    }

}
