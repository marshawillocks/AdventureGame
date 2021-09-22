using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class StartGame
    {
        public void Play()
        {
            PlayerInfo();
            GettingDress();
            Endgame();
        }

        //Get the user's information: name, age, grade
        public void PlayerInfo()
        {
            Console.WriteLine("Welcome Player, Please enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter an age between 14 and 18");
            int age = int.Parse(Console.ReadLine());

            if (age < 14)
            {
                Console.WriteLine("You are way too young, for high school.  Come back when you are older");
            }
            if (age == 14 || age == 15)
            {
                Console.WriteLine("Congrats freshman, welcome to high school");
            }
            if (age == 16)
            {
                Console.WriteLine("Congrats Sophmore, welcome back");
            }
            if (age == 17)
            {
                Console.WriteLine("Congrats Junior, welcome back");
            }
            if (age == 18)
            {
                Console.WriteLine("Congrats seniors, It's your last year.  Live it up!");
            }
            if (age > 18)
            {
                Console.WriteLine("You're too old for high school");
            }
        }

        //Make scenario 1 (Getting Dress)
        public void GettingDress()
        {
            Console.Clear();
            Console.WriteLine("It's your first day of school.  Do you want to\n" +
                "1.Dress to impress\n" +
                "2.Keep it casual.\n" +
                "3.Dress like a slob\n" +
                "Please make your selection below");
            int gettingDress = int.Parse(Console.ReadLine());

            switch (gettingDress)
            {
                case 1: //dress to impress
                    Console.WriteLine("Way to go, you killed it while turning heads");
                    ClassSchedule();
                    break;
                case 2: //keep it casual
                    Console.WriteLine("Cool, calm and collected. Good start to the day");
                    ClassSchedule();
                    break;
                case 3: //dress like a slob
                    Console.WriteLine("You got to school and your pants ripped.  You had to go home and change but no ride back to school.\n" +
                        "Your day is OVER and so is this game.  Better luck next time!");
                    break;
            }
        }

        //Make scenario 2 (Made it to school)
        public void ClassSchedule()
        {
            Console.Clear();
            Console.WriteLine("Class is about to start... What's next? \n" +
                "1.Chat with your Friends\n" +
                "2.Pick up your schedule from the office.\n" +
                "3.Skip the first day and go to beach with friends.\n" +
                "Please make your selection below");
            int classSchedule = int.Parse(Console.ReadLine());

            switch (classSchedule)
            {
                case 1:
                    Console.WriteLine("Great conversations and got schedule.  Way to start your day off!");
                    Seat();
                    break;
                case 2:
                    Console.WriteLine("Way to stay on track!");
                    Seat();
                    break;
                case 3:
                    Console.WriteLine("You are already making bad decisions.  Hopefully you choose better next time.  Game over.");
                    break;
            }
        }

        //Make scenario 3 (Class Seat)`
        public void Seat()
        {
            Console.Clear();
            Console.WriteLine("First class of the day.  Where are you going to sit\n" +
                "1.front\n" +
                "2.middle\n" +
                "3.back\n" +
                "Please make your selection below");
            int seat = int.Parse(Console.ReadLine());

            switch (seat)
            {
                case 1:
                    Console.WriteLine("ok smarty pants.  you're off to a great start ");
                    Lunch();
                    break;
                case 2:
                    Console.WriteLine("Way to play it safe.");
                    Lunch();
                    break;
                case 3:
                    Console.WriteLine("Hopefullly you can stay focus and not get distracted by troublemakers around you");
                    Lunch();
                    break;
            }

        }
        //Make scenario 4 (Luch)
        public void Lunch()
        {
            Console.Clear();
            Console.WriteLine("Best time of the day. LUNCH TIME.....What to eat\n" +
                "1.Cafeteria food\n" +
                "2.Lunch from home.\n" +
                "3.Stale sandwich from yesterday\n" +
                "Please make your selection below");
            int Lunch = int.Parse(Console.ReadLine());

            switch (Lunch)
            {
                case 1:
                    Console.WriteLine("The pizza was great");
                    LastClass();
                    break;
                case 2:
                    Console.WriteLine("Nothing is better than a homemade lunch. Yum....");
                    LastClass();
                    break;
                case 3:
                    Console.WriteLine("uh oh, somebody got food poisining.  What a great way to end your day.  You have to go home.  Game over!");
                    break;
            }
        }
            //Make scenario 5 (Last class)
            public void LastClass()
            {
            Console.Clear();
            Console.WriteLine("It's almost the end of the day.  Yippie!\n" +
                    "1.Skip class\n" +
                    "2.Attend class\n" +
                    "Please make your selection below");
                int lastClass = int.Parse(Console.ReadLine());

                switch (lastClass)
                {
                    case 1: 
                        Console.WriteLine("Wow you almost made it. But you didn't. Game over. YOU LOSE!\n");
                        break;
                    case 2: 
                        Console.WriteLine("*****CONGRATS YOU SUCCESSFULLY COMPLETED YOUR FIRST DAY OF SCHOOL*****\n");                            
                        break;                   
                }             
            }
            
            //End Game
            public void Endgame()
        {
            Console.WriteLine("Press any key to close the came");
            Console.ReadLine();
        }

    }
}
