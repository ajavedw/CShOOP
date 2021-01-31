using System;
interface IAnimal
{
    void Speak();
}

class Dog : IAnimal
{
    public virtual void Speak()
    {
       Console.WriteLine("Bark!");
    }
}

class GoldenRetriever : Dog
{
    public override void Speak()
    {
        Console.WriteLine("I am a golden retriever who says ");
    }
}