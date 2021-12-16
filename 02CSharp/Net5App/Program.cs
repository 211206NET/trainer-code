using System;

namespace Net5App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick an animal");
            Console.WriteLine("[0] Auryn the Cat");
            Console.WriteLine("[1] Penny the Rabbit");
            string input = Console.ReadLine();
            IAnimal animal;
            switch(input)
            {
                case "0":
                    animal = new Auryn();
                break;
                case "1":
                    animal = new Penny();
                break;
                default:
                    animal = new Auryn();
                break;
            }

            animal.Eat();
            animal.Sleep();
        }
    }


    public interface IAnimal
    {
        void Eat();

        void Sleep();
    }

    public interface IMammal
    {
        void Breathe();

        void GiveBirth();
    }

    public interface ICat
    {
        void Purr();

        void JudgePeople();

        void Scratch();
    }

    public class Penny : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("Penny munches");
        }
        public void Sleep()
        {
            Console.WriteLine("Penny sleeps like a loaf of bread");
        }
    }

    public class Auryn : IAnimal, ICat, IMammal
    {
        public void Eat()
        {
            Console.WriteLine("Auryn Eats (too much)");
        }

        public void Sleep()
        {
            Console.WriteLine("She slinks to her favorite bed by the heater and takes a long post breakfast nap while I work");
        }

        public void Breathe()
        {
            Console.WriteLine("*gasp*");
        }

        public void GiveBirth()
        {
            Console.WriteLine("She's a spayed kitty, her birth giving years are behind her");
        }
        public void Purr()
        {
            Console.WriteLine("purrrr _feed me_ purrrr");
        }

        public void JudgePeople()
        {
            Console.WriteLine("*stares* (are you sure your demos are correct)");
        }

        public void Scratch()
        {
            Console.WriteLine("She sometimes scratches all the right things, sometimes all the wrongs things for attention");
        }
    }
}
