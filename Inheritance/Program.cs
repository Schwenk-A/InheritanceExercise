using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my very small zoo. Let me take you around,");
            UserChoiceStart();







        }

        public static void UserChoiceStart()
        {
            string customerResponse = "";
            do
            {
                Console.WriteLine("would you like to see the birds or reptiles ? ");
                customerResponse = Console.ReadLine();
            } while (customerResponse != "birds" && customerResponse != "bird" && customerResponse != "reptiles");

            if (customerResponse == "birds" || customerResponse == "bird")
            {
                Console.Clear();
                DisplayBird();
            }
            else
            {
                Console.Clear();
                DisplayReptiles();
            }
        }

        public static void DisplayBird()
        {
            Console.WriteLine("Birds was a lovely choice!");
            Console.WriteLine("");
            Console.WriteLine("I have two birds here Jim and Bob, who would you like to see?");
            var userPickBird = Console.ReadLine().ToLower();
            Console.Clear();
            //---------------------------------------------------
            Bird baldEagleJim = new Bird();
            baldEagleJim.FeatherColors = "Brown with white on the head";
            baldEagleJim.LifeSpan = 30;


            Bird parrotBob = new Bird();
            parrotBob.FeatherColors = "Red and Blue";
            parrotBob.LifeSpan = 60;
            //---------------------------------------------------
            if (userPickBird == "bob")
            {
                Console.WriteLine($"Ahhh Bob's a cool one, he is a Parrot...\n" +
                $"You can see he has a beautiful coloring of {parrotBob.FeatherColors}.\n" +
                $"He enjoyes eating {parrotBob.FoodType}, and can live up to {parrotBob.LifeSpan}.\n" +
                $" it is {parrotBob.HasFeathers} that Parrots like Bob have feathers.\n" +
                $" same as it is {parrotBob.HasWings} that they have wings.");
            }
            else if (userPickBird == "jim")
            {
                Console.WriteLine($"Jim's my favorite one...don't tell Bob though.. Let me tell you why" +
                    $"To start with Jim is colored {baldEagleJim.FeatherColors} which is not so colorful as Bob \n" +
                    $" and thats better on my eyes. His lifespan is {baldEagleJim.LifeSpan} which makes time more precious\n" +
                    $" He does have some similarities to all birds like having {baldEagleJim.Legs} legs \n" +
                    $"and it's {baldEagleJim.HasWings} that he has wings and {baldEagleJim.HasFeathers} he has feathers.\n" +
                    $"But he has a cool personality that Jim.... What?? Nothing more you want to know? fine.. ");

            }
            else
            {
                Console.WriteLine("You didn't give me a valid name");
                DisplayBird();
            }
         

        }

        public static void DisplayReptiles()
        {
            Reptile lizardJoe = new Reptile();
            lizardJoe.Color = "Green";
            lizardJoe.YearofBirth = 1993;
            lizardJoe.LifeSpan = 5;
            lizardJoe.ScaleFeel = "smooth";

            Reptile iguanaDan = new Reptile();
            iguanaDan.Color = "Blueish-green";
            iguanaDan.YearofBirth = 2018;
            iguanaDan.LifeSpan = 15;

            //---------------------------------------------------
            Console.WriteLine("Reptiles, living on the wild side i see ");
            Console.WriteLine("I have two Reptiles with me today, Do you want to see Joe or Dan? Or would you like to compare?");
            Console.WriteLine("option 1 Joe");
            Console.WriteLine("option 2 Dan");
            Console.WriteLine("option 3 Compare"); 
            var userinput = Console.ReadLine().ToLower();
            Console.Clear();
            //---------------------------------------------------
            if (userinput == "joe")
            {
                Console.WriteLine($"So Joe is an interesting guy, he is a Lizard. As with all reptiles has {lizardJoe.Legs} legs\n" +
                    $"the normal lifespan for a lizard is {lizardJoe.LifeSpan} but Joe was born in {lizardJoe.YearofBirth}\n" +
                    $"So he is...defying odds. You can see his coloring is {lizardJoe.Color} and he feels {lizardJoe.ScaleFeel}");
            }
            else if (userinput == "Dan")
            {
                Console.WriteLine($"Now Dan.... Im not getting near him. he always looks at me funny.\n" +
                    $"But, i guess i can tell you about him. He was born in {iguanaDan.YearofBirth} \n" +
                    $"he can live up to {iguanaDan.LifeSpan} if i was brave enough to get close i would say \n" +
                    $"his skin feels {iguanaDan.ScaleFeel}... He just hissed at me so im out of here...bye!");
            }
            else if (userinput == "compare")
            {
                Console.WriteLine("Sorry Fax machine broke. No comparison sheets yet.");
            }
            else
            {
                Console.WriteLine("Sorry I didn't catch that try again.");
                DisplayReptiles();
            }
            


        }
    }
}
