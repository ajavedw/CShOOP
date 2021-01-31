using System;

/* public abstract class Laptop

{
    public virtual void TurnOn(){
        Console.WriteLine("Turn on.");
    }

    public  void TurnOff(){
        Console.WriteLine("Turn off.");
    }

    public abstract bool TouchScreen{get;}
} */

//ThreadStaticAttribute is without using interface. we have to define everything here and then use it. 
//In case of interface we just need to write the contract, i.e the methods and varibale and using that 
//interface we will develop our classes

//using interface

    public interface Laptop

    {
        void TurnOn(){   }


        // method with same name but different parameters i.e static polymorphism
        // this is also called as method over loading. we will have method with same name 
        // but different signature
        void TurnOn(bool accessBIOS){}  

        void TurnOff(){}

        //abstract/virtual void methodOverRide(string name){   } 
        //for above; just realized that i cannot abstract/virtual type method in interface as per this
        /* Interface is not Base Class, so implementation methods are not overriden. Interface only declares 
        the methods, Interface methods are not virtual by default, infact interfaces only declare the 
        methods that are available on the class that implements that interface.

        Declaration can not be virtual.
        Implementation can or cannot be virtual that is completely dependent on the implementer's logic.


        Interfaces are just a type with the virtual methods so the behaviour should be same as classes.
        – Mohit Bhandari Dec 17 '10 at 12:59 
        2

        @Mohit - This is not entirely true. Yes they are just another type but they are an interface type
        which makes all the difference. Interfaces and classes are different at the IL level. 
        – Andrew Hare Dec 17 '10 at */

        bool TouchScreen{get;}
    }