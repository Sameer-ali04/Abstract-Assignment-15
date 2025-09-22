
using System;

namespace Project
{
    delegate void Greet(string name);
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");

            FromClass1 c1 = new FromClass1();// this line gives us an example of Abstraction and polymorphism
            c1.Name = Console.ReadLine();
            Console.WriteLine();

           

            Console.WriteLine("The Name You have entered is stored in ChildClass1 and will be used  from ChildClass2");

            IPractice c2 = new FromClass2(c1.Name);// this line gives us an example of Abstraction and polymorphism

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Press Enter Every time for Next step");
            Console.ReadKey();

            Console.WriteLine("Let me Show You the exaples of Abstraction + Polymorphism (UpCasting) + Inheritance + Encapsulation ");

            Console.WriteLine(Environment.NewLine);
            Console.ReadKey();

            c1.Message();

            Console.WriteLine(Environment.NewLine);
            Console.ReadKey();

            c2.Message();

            Console.ReadKey();


        }
        public static void Greetings(string name)
        {
            Console.WriteLine("Hey there " + name);
        }
    }
    interface IPractice
    {
        void Message();
    }

    class FromClass1 : IPractice
    {
        private string name;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public FromClass1()
        {
            Console.WriteLine("Your name is being stored in ChildClass1 to promote Encapsulation");
        }

        public void Message()
        {
            Console.WriteLine("This message is being displayed from Class1 which is implemented from an Interface");
        }

    }

    class FromClass2 : IPractice
    {
        private string Name;
        public FromClass2(string Name)
        {
            this.Name = Name;
            Console.WriteLine("Hey " + Name + "!");
            Console.WriteLine("Welcome To The Demonstration of OOPS Concepts (This message is from Constructor of ChildClass2)");
        }

        public void Message()
        {
            Console.WriteLine("This message is being displayed from Class2 which is implemented from an Interface");
        }


    }
}



    