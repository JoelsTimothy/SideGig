using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;
using System.Threading;
using System.Net.Cache;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.ComTypes;
using System.Drawing;
using System.Transactions;
using System.Xml.Schema;

namespace CSC205JoelTimothy
{
    class Program
    {
        static void Main(string[] args)
        {

            

            int[] numbers = new int[9] { 1234, 2345, 3456, 4567, 5678, 6789, 7890, 8901, 9012};
            Console.WriteLine(numbers[0]);

            Console.WriteLine("Welcome to Golds Gym!");
            Console.Write("Are you a Gold Customer? True or False: ");
            bool isGoldCustomer = Convert.ToBoolean(Console.ReadLine());

            float price;
            if (isGoldCustomer)
            {
                MembershipNumber();
            }
            else
            {
                price = 29.95f;
                Console.WriteLine("Welcome to Golds Gym!  Your entrance fee will be {0}", price);
            }

            Console.WriteLine();
            Console.WriteLine("Please press enter to continue...");
            string enter = Console.ReadLine();

            EnterGym();

            bool DisplayWorkout = true;
            while(DisplayWorkout ==true)
            {
                DisplayWorkout = ChooseWorkout();
            }

            
            PoolTime();

            Blood.BloodType();

            Blood.BloodTest();

            GoHome();

        }

        

        private static void MembershipNumber()
        {
            int[] numbers = new int[9] { 1234, 2345, 3456, 4567, 5678, 6789, 7890, 8901, 9012 };
            Console.Write("Please type in your 4 digit membership number: ");
            int result = Convert.ToInt32(Console.ReadLine());

            float price;
            if (numbers.Contains(result))
            {
                price = 19.95f;
                Console.WriteLine("Welcome Gold Member!  Your entrance fee today is only {0}", price);                
            }
            else
            {
                LoginAttempt1();
            }         

        }
                

        private static void LoginAttempt1()   
        {
            int loginAttempts = 0;
            float price;
            for (int i = 1; i< 3; i++)
            {
                int[] numbers = new int[9] { 1234, 2345, 3456, 4567, 5678, 6789, 7890, 8901, 9012 };
                Console.WriteLine("Incorrect membership number");
                Console.Write("Please type in your 4 digit membership number again: ");
                int result = Convert.ToInt32(Console.ReadLine());

                if (numbers.Contains(result))
                {
                    price = 19.95f;
                    Console.WriteLine("Welcome Gold Member!  Your entrance fee today is only {0}", price);                    
                 break;
                }
                else
                    loginAttempts++;

            }

            if (loginAttempts > 1)
            {
                price = 29.95f;
                Console.WriteLine("Login Failure.  We cannot confirm your membership.  Please confirm with staff, or pay todays entrance fee of {0}", price);

                Console.WriteLine("Would you like to reset your pin? True/False");
                bool Resetpin = Convert.ToBoolean(Console.ReadLine());
                              
                if (Resetpin == true)
                {
                    RedoPin();
                }
                else
                {
                    price = 29.95f;
                    Console.WriteLine("Maybe next time.  Your entrance fee will be {0}", price);                   
                }  
            }
        }


        private static void RedoPin()
        {             
            int Attempts = 0;
                            
                for (int i = 0; i < 3; i++)
                {
                    string[] Name = {"ADAM", "BEN", "CREG", "DEVON", "ERIC", "FRANK", "GREG", "HANK", "IGOR"};
                    Console.WriteLine("Please enter your First name in order to verify your membership:");
                    string Name1 = Console.ReadLine().ToUpper();                                   
                    
                    if (Name.Contains(Name1))
                    {
                        float price = 29.95f;
                        Console.WriteLine("Thank you {0}!  We have verified your name in the system.  Your entrance fee will be {1} ",Name1, price);                       
                    break;
                    }
                    else
                        Attempts++;
                    
                    if (Attempts > 2)
                    {
                        float price = 29.95f;
                        Console.WriteLine("You know what {0}, we'll just give you the member price today, {1} please", Name1 ,price);
                    }
                }  
        }


        private static void EnterGym()
        {
            int correct = 0;         

            do
            {
                Console.Clear();

                GymAtire Gymguy1 = new GymAtire();

                Console.WriteLine("Now you are in the Futuristic locker room.");
                Console.WriteLine("You need to choose your one time one-time-use instant biodegradable gym clothes.");
                Console.WriteLine("------------------------------");
                Console.WriteLine("What color is your shirt?");
                Gymguy1.ShirtColor = Console.ReadLine();
                Console.WriteLine("What brand is your shirt?");
                Gymguy1.ShirtBrand = Console.ReadLine();
                Console.WriteLine("What color are your shorts?");
                Gymguy1.ShortColor = Console.ReadLine();
                Console.WriteLine("What brand are your shorts");
                Gymguy1.ShortBrand = Console.ReadLine();
                Console.WriteLine("What color are your shoes?");
                Gymguy1.ShoeColor = Console.ReadLine();
                Console.WriteLine("What brand are your shoes?");
                Gymguy1.ShoeBrand = Console.ReadLine();
                Console.WriteLine("What color is your 90s sweatband?");
                Gymguy1.BandColor = Console.ReadLine();
                Console.WriteLine("What brand is your 90s sweatband?");
                Gymguy1.SweatBrand = Console.ReadLine();

                Gymguy1.PrintGymClothes();

                Console.WriteLine("Do dare exercise in that? Yes/No:");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "YES")
                {

                    correct = 1;
                }
                if (answer =="NO")
                {
                    correct = 0;
                    
                }

            } while (correct == 0);
        }


        private static bool ChooseWorkout()
        {
            Console.Clear();

            Console.WriteLine("Choose your workout");
            Console.WriteLine("1) Treadmill");
            Console.WriteLine("2) Stationary Bicycle");
            Console.WriteLine("3) Swim");
            Console.WriteLine("4) Move on");
            string result = Console.ReadLine();

            if(result =="1")
            {
                Treadmill();
                return true;
            }
            else if(result =="2")
            {
                StationaryBicycle();
                return true;
            }
            else if(result == "3")
            {
                Swim();
                return true;
            }
            else if (result == "4")
            {
                MoveOn();
                return false;
            }
            else
            {
                return true;
            }           

        }

        private static void Treadmill()
        {

            Console.Clear();

            float CaloriePerMinute = 11.4f;
            float TotalCalorie;
            float ActualRunCount;

            Console.WriteLine("Type a number of minutes you might be interested in running: ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            for (int minute = 0; minute < minutes; minute++)
            {
                TotalCalorie = minute * CaloriePerMinute;
                Console.WriteLine("{0} minutes running = {1} calories burned.", minute, TotalCalorie);
            }                    

            int correct = 0;
            do
            {
                Console.WriteLine("So, how many minutes would you like to run? ");
                int minutes1 = Convert.ToInt32(Console.ReadLine());

                ActualRunCount = minutes1 * CaloriePerMinute;
                Console.WriteLine("Good job! You ran {0} minutes and burned {1} calories!", minutes1, ActualRunCount);

                Console.WriteLine("Would you like run again?");                
                string answer = Console.ReadLine().ToUpper();
                if (answer == "YES")
                {
                    Console.Clear();
                    correct = 0;
                }
                if (answer == "NO")
                {
                    correct = 1;
                    ChooseWorkout();

                }
            } while (correct == 0);

        }

        private static void StationaryBicycle()
        {
            Console.Clear();

            float CaloriePerMinute = 13.02f;
            float TotalCalorie;
            float ActualCount;

            Console.WriteLine("Type a number of minutes you might be interested in bike riding? ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            for (int minute = 0; minute < minutes; minute++)
            {
                TotalCalorie = minute * CaloriePerMinute;
                Console.WriteLine("{0} minutes riding = {1} calories burned.", minute, TotalCalorie);
            }

            int correct = 0;
            do
            {
                Console.WriteLine("So, how many minutes would you like to ride? ");
                int minutes1 = Convert.ToInt32(Console.ReadLine());

                ActualCount = minutes1 * CaloriePerMinute;
                Console.WriteLine("Amazing job! You rode {0} minutes and burned {1} calories!", minutes1, ActualCount);

                Console.WriteLine("Would you like ride again?");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "YES")
                {
                    Console.Clear();
                    correct = 0;
                }
                if (answer == "NO")
                {
                    correct = 1;
                    ChooseWorkout();

                }
            } while (correct == 0);


        }

        private static void Swim()
        {

            Console.Clear();

            float CaloriePerMinute = 10.5f;
            float TotalCalorie;
            float ActualCount;

            Console.WriteLine("Type a number of minutes you might be interested in swimming? ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            for (int minute = 0; minute < minutes; minute++)
            {
                TotalCalorie = minute * CaloriePerMinute;
                Console.WriteLine("{0} minutes riding = {1} calories burned.", minute, TotalCalorie);
            }

            int correct = 0;
            do
            {
                Console.WriteLine("So, how many minutes would you like to swim? ");
                int minutes1 = Convert.ToInt32(Console.ReadLine());

                ActualCount = minutes1 * CaloriePerMinute;
                Console.WriteLine("Amazing job! You swam {0} minutes and burned {1} calories!", minutes1, ActualCount);

                Console.WriteLine("Would you like swim again?");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "YES")
                {
                    Console.Clear();
                    correct = 0;
                }
                if (answer == "NO")
                {
                    correct = 1;
                    ChooseWorkout();

                }
            } while (correct == 0);

        }

        private static void MoveOn()
        {

            Console.WriteLine("OH @$%#, your personal trainer just saw you and is coming over to ask you about your training");
            
            StreamWriter outFile = new StreamWriter(@"Trainer.txt", true);

            Console.WriteLine("TRAINER: Hey man, I remember your face from last week, I lost your file and need to do it over again.  I need to re-ask you some questions");
            Console.WriteLine("What is your name?: ");
            string Name = Console.ReadLine();
            outFile.WriteLine("Name: " + Name);
            Console.WriteLine("What is your age?: ");
            string Age = Console.ReadLine();
            outFile.WriteLine("Age: " + Age);
            Console.WriteLine("What is your current weight in pounds?: ");
            int Weight = Convert.ToInt32(Console.ReadLine());
            outFile.WriteLine("Your weight: " + Weight);
            Console.WriteLine("How many times a week do you exercise?: ");
            int Times = Convert.ToInt32(Console.ReadLine());
            outFile.WriteLine("Times you work out: " + Times);
            Console.WriteLine("Lastly, for how many minutes?: ");
            int Minutes = Convert.ToInt32(Console.ReadLine());
            outFile.WriteLine("Minutes you work out: "+ Minutes);
            Console.WriteLine();
            Console.WriteLine("Great!  Thanks for that!  Here's a copy of your info if you'd like.");
            Console.WriteLine("Please press enter to accept the paper...");
            string enter = Console.ReadLine();

            outFile.Close();

            StreamReader inFile = new StreamReader(@"C:\Users\Joel\source\repos\CSC205JoelTimothy\CSC205JoelTimothy\bin\Debug\Trainer.txt");

            Console.Clear();

            Console.WriteLine("You look down at all the lies you told him...");

            string line = inFile.ReadLine();//reads line in file
            while (line != null)// reads all lines that don't equal null
            {
                Console.WriteLine(line);        
                line = inFile.ReadLine();    //moves to the next line
            }

            Console.WriteLine("Please press enter to continue...");
            string enter1 = Console.ReadLine();

            inFile.Close(); //closes out the file            

        }

        private static void PoolTime()
        {

            Console.Clear();

            Console.WriteLine("You now enter the changing area for the hot tub.  You look around for your swim clothes but they are gone!");
            Console.WriteLine("The gym has some swim atire available, but you find that they have only one set left.");

            ForcedAtire();
            Console.WriteLine();
            Console.WriteLine("You begin to get thirsty after spending 15 minutes in the hot tub");
            Console.WriteLine();
            Console.WriteLine("Please press enter to get a drink...");
            string enter = Console.ReadLine();            

        }

        public static SwimAtire ForcedAtire()
        {
            SwimAtire ForcedSwimAtire = new SwimAtire(GoggleColor.Pink, SwimShortsColor.Red, FlipperColor.White, ArmFloatyColor.Blue);
            ForcedSwimAtire.PrintSwimmingAtire();
            return ForcedSwimAtire;
        }

        public static void GoHome()
        {
            Console.Clear();

            Console.WriteLine("You have experienced more than what you were expecting today!");
            Console.WriteLine("You feel pretty tired, but you feel well enough to keep exercising");
            Console.WriteLine("Go back and exercise? Yes/No");
            string answer = Console.ReadLine().ToUpper();
            if (answer == "YES")
            {
                Console.WriteLine("You get stopped by the security guard who says that they are closing up the place");
                ReallyGoHome();
            }
            if (answer == "NO")
            {
                ReallyGoHome();
            }
        }

        

        private static void ReallyGoHome()
        {
            Console.WriteLine("You go home");        
        }


    }

    class Blood
    {
        public static void BloodType()
        {
            Console.Clear();

            Console.WriteLine("As you get out of the pool, you see a guy trip and fall slicing his head open.");
            Console.WriteLine("Blood is flowing out of his head is loosing blood fast.  You know you have to act now.");
            Console.WriteLine("Interestingly enough, there is a prefessional medical office by the pool with a blood supply");
            Console.WriteLine("You find out that the guys blood type is B- from their wife.");
            Console.WriteLine("You rush to the blood supply to get blood.  They are all out of B-, but have everything else.");
            Console.WriteLine("What other type of blood can a B- recieve?");
            string blood = Console.ReadLine().ToUpper();
            if (blood == "O-")
                Console.WriteLine("You are right!  You have succesfully saved the mans life!");
            else
            {
                Console.WriteLine("The man died.");
            }

            Console.WriteLine("Press enter to continue...");
            string enter = Console.ReadLine();

            Console.WriteLine("You see the local medic come running over.  He asks if you want to go over your blood types again.");
            Console.WriteLine("What do you think? Yes/No?");
            string answer = Console.ReadLine().ToUpper();
            if (answer == "YES")
            {
                BloodTest();
            }
            else
            {
                Console.WriteLine("He dissagrees with you and hands you the review.");
                Console.WriteLine();
                
            }

        }


        public static void BloodTest()
        {
            
            string[] DonateABpos = { "AB+" };
            string[] DonateABneg = { "AB+", "AB-" };
            string[] DonateApos = { "AB+", "A+" };
            string[] DonateAneg = { "AB+", "AB-", "A+", "A-" };
            string[] DonateBpos = { "AB+", "B+" };
            string[] DonateBneg = { "AB+", "AB-", "B+", "B-" };
            string[] DonateOpos = { "AB+", "A+", "B+", "O+" };
            string[] DonateOneg = { "AB+", "AB-", "A+", "A-", "B+", "B-", "O+", "O-" };

            string[] RecipientABpos = { "AB+", "AB-", "A+", "A-", "B+", "B-", "O+", "O-" };
            string[] RecipientABneg = { "AB-", "O-", "A-", "B-"  };
            string[] RecipientApos = { "A+", "A-", "O+", "O-" };
            string[] RecipientAneg = { "A-", "O-" };
            string[] RecipientBpos = { "B+", "B-", "O+", "O-" };
            string[] RecipientBneg = { "B-", "O-" };
            string[] RecipientOpos = { "O+", "O-" };
            string[] RecipientOneg = { "O-" };

            
            int RightAnswer = 0;
            int WrongAnswer = 0;


            Console.WriteLine("Just write ONE answer");

            Console.WriteLine("A+ blood can donate to: ");
            string Question1 = Console.ReadLine().ToUpper();
            if(DonateApos.Contains(Question1))
            {
                Console.WriteLine("Correct!");
                RightAnswer++;
            }
            else
            {
                Console.WriteLine("Wrong");
                WrongAnswer++;
            }

            Console.WriteLine("B- blood can donate to: ");
            string Question2 = Console.ReadLine().ToUpper();
            if (DonateBneg.Contains(Question2))
            {
                Console.WriteLine("Correct!");
                RightAnswer++;
            }
            else
            {
                Console.WriteLine("Wrong");
                WrongAnswer++;
            }

            Console.WriteLine("O+ blood can donate to: ");
            string Question3 = Console.ReadLine().ToUpper();
            if (DonateOpos.Contains(Question3))
            {
                Console.WriteLine("Correct!");
                RightAnswer++;
            }
            else
            {
                Console.WriteLine("Wrong");
                WrongAnswer++;
            }

            Console.WriteLine("AB+ blood can donate to: ");
            string Question4 = Console.ReadLine().ToUpper();
            if (DonateABpos.Contains(Question4))
            {
                Console.WriteLine("Correct!");
                RightAnswer++;
            }
            else
            {
                Console.WriteLine("Wrong");
                WrongAnswer++;
            }

            Console.WriteLine("O- blood can donate to: ");
            string Question5 = Console.ReadLine().ToUpper();
            if (DonateOneg.Contains(Question5))
            {
                Console.WriteLine("Correct!");
                RightAnswer++;
            }
            else
            {
                Console.WriteLine("Wrong");
                WrongAnswer++;
            }         

            Console.WriteLine("A+ blood can be a recipient of: ");
            string Question6 = Console.ReadLine().ToUpper();
            if (RecipientApos.Contains(Question6))
            {
                Console.WriteLine("Correct!");
                RightAnswer++;
            }
            else
            {
                Console.WriteLine("Wrong");
                WrongAnswer++;
            }

            Console.WriteLine("B- blood can be a recipient of: ");
            string Question7 = Console.ReadLine().ToUpper();
            if (RecipientBneg.Contains(Question7))
            {
                Console.WriteLine("Correct!");
                RightAnswer++;
            }
            else
            {
                Console.WriteLine("Wrong");
                WrongAnswer++;
            }

            Console.WriteLine("AB- blood can be a recipient of: ");
            string Question8 = Console.ReadLine().ToUpper();
            if (RecipientABneg.Contains(Question8))
            {
                Console.WriteLine("Correct!");
                RightAnswer++;
            }
            else
            {
                Console.WriteLine("Wrong");
                WrongAnswer++;
            }

            Console.WriteLine("O+ blood can be a recipient of: ");
            string Question9 = Console.ReadLine().ToUpper();
            if (RecipientOpos.Contains(Question9))
            {
                Console.WriteLine("Correct!");
                RightAnswer++;
            }
            else
            {
                Console.WriteLine("Wrong");
                WrongAnswer++;
            }

            Console.WriteLine("O- blood can be a recipient of: ");
            string Question10 = Console.ReadLine().ToUpper();
            if (RecipientApos.Contains(Question10))
            {
                Console.WriteLine("Correct!");
                RightAnswer++;
            }
            else
            {
                Console.WriteLine("Wrong");
                WrongAnswer++;
            }
                        
            Console.WriteLine("You got {0} correct answers.", RightAnswer);
            Console.WriteLine("You got {0} incorrect answers.", WrongAnswer);

            Console.WriteLine();
            Console.WriteLine("Please press enter to continue...");
            string enter = Console.ReadLine();


        }
    }

    struct GymAtire
    {
        public string ShirtColor { get; set; }
        public string ShortColor { get; set; }
        public string ShoeColor { get; set; }
        public string BandColor { get; set; }

        public string ShirtBrand { get; set; }
        public string ShortBrand { get; set; }
        public string ShoeBrand { get; set; }
        public string SweatBrand { get; set; }

        public void PrintGymClothes()
        {
            Console.WriteLine();
            Console.WriteLine($"You have chosen to wear: a {ShirtColor} {ShirtBrand} shirt, {ShortColor} {ShortBrand} shorts, ");
            Console.WriteLine($"{ShoeColor} {ShoeBrand} shoes, and a {BandColor} {SweatBrand} SweatBand");
            Console.WriteLine();
        }

        public GymAtire(string ShirtColor, string ShirtBrand, string ShortColor, string ShortBrand, string ShoeColor, string ShoeBrand, string BandColor, string SweatBrand)
        {
            this.ShirtColor = ShirtColor;
            this.ShirtBrand = ShirtBrand;
            this.ShortColor = ShortColor;
            this.ShortBrand = ShortBrand;
            this.ShoeColor = ShoeColor;
            this.ShoeBrand = ShoeBrand;
            this.BandColor = BandColor;
            this.SweatBrand = SweatBrand;
        }
    }


    enum GoggleColor {White, Black, Blue, Yellow, Red, Green, Pink}
    enum SwimShortsColor {White, Black, Blue, Yellow, Red, Green, Pink}
    enum FlipperColor {White, Black, Blue, Yellow, Red, Green, Pink}
    enum ArmFloatyColor {White, Black, Blue, Yellow, Red, Green, Pink}

    struct SwimAtire
    {
        private GoggleColor GoggleColor { get; set; }
        private SwimShortsColor SwimShortsColor { get; set; }
        private FlipperColor FlipperColor { get; set; }
        private ArmFloatyColor ArmFloatyColor { get; set; }


        public void PrintSwimmingAtire()
        {
            Console.WriteLine();
            Console.WriteLine($"You have no choice but to wear: {GoggleColor} goggles, {SwimShortsColor} shorts,");
            Console.WriteLine($"{FlipperColor} flippers, {ArmFloatyColor} arm floaties into the hot tub.");
            Console.WriteLine();
        }
                

        public SwimAtire(GoggleColor GoggleColor, SwimShortsColor SwimShortsColor, FlipperColor FlipperColor, ArmFloatyColor ArmFloatyColor)
        {
            this.GoggleColor = GoggleColor;
            this.SwimShortsColor = SwimShortsColor;
            this.FlipperColor = FlipperColor;
            this.ArmFloatyColor = ArmFloatyColor;
            
        }

    }



}
