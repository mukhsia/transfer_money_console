using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTransfer
{
    internal class Simulation
    {
        public Simulation()
        {
            
        }

        // Bonus Stories: Add 3 additional Person objects, Provide the user a menu
        // The menu should allow the user to:
        // 1. Select any of the 5 people as a giver
        // 2. Select a transfer balance (Input an amount)
        // 3. Select a receiver/ recepient from one of the other people
        public void menuBonusStory(Person personOne, Person personTwo, Person personThree, Person personFour, Person personFive)
        {
            int giverOption;
            int receiverOption;

            Person giver = personOne;
            Person receiver = personOne;
            int amountToSend = 100;

            do
            {
                // Select any of the 5 people as a giver
                Console.WriteLine("\nBonus Stories | Menu for Transfers");
                Console.WriteLine("0. Stop Simulation");
                Console.WriteLine($"1. {personOne.name}");
                Console.WriteLine($"2. {personTwo.name}");
                Console.WriteLine($"3. {personThree.name}");
                Console.WriteLine($"4. {personFour.name}");
                Console.WriteLine($"5. {personFive.name}");

                Console.Write("Select a Giver (0-5): ");
                giverOption = Convert.ToInt32(Console.ReadLine());

                if (giverOption < 0 || giverOption > 5)
                {
                    Console.WriteLine("Invalid Giver value entered.");
                }
                else if (giverOption > 0)
                {
                    switch (giverOption)
                    {
                        case 1:
                            giver = personOne;
                            break;
                        case 2:
                            giver = personTwo;
                            break;
                        case 3:
                            giver = personThree;
                            break;
                        case 4:
                            giver = personFour;
                            break;
                        case 5:
                            giver = personFive;
                            break;
                        default:
                            break;
                    }

                    // 2. Select a transfer balance
                    do
                    {
                        Console.Write("Enter an amount to send: ");
                        amountToSend = Convert.ToInt32(Console.ReadLine());


                        if (amountToSend < 1)
                        {
                            Console.WriteLine("Invalid transfer amount option entered.");
                        }

                    } while (amountToSend < 1);

                    // 3. Select a receiver/ recepient from one of the other people
                    do
                    {
                        Console.WriteLine();
                        if (giverOption != 1)
                        {
                            Console.WriteLine($"1. {personOne.name}");
                        }

                        if (giverOption != 2)
                        {
                            Console.WriteLine($"2. {personTwo.name}");
                        }

                        if (giverOption != 3)
                        {
                            Console.WriteLine($"3. {personThree.name}");
                        }

                        if (giverOption != 4)
                        {
                            Console.WriteLine($"4. {personFour.name}");
                        }

                        if (giverOption != 5)
                        {
                            Console.WriteLine($"5. {personFive.name}");
                        }

                        Console.Write("\nSelect a receiver (1-5): ");
                        receiverOption = Convert.ToInt32(Console.ReadLine());

                        if (giverOption == receiverOption || receiverOption < 1 || receiverOption > 5)
                        {
                            Console.WriteLine("Invalid reciever option selected.");
                        }
                        else
                        {
                            switch (receiverOption)
                            {
                                case 1:
                                    receiver = personOne;
                                    break;
                                case 2:
                                    receiver = personTwo;
                                    break;
                                case 3:
                                    receiver = personThree;
                                    break;
                                case 4:
                                    receiver = personFour;
                                    break;
                                case 5:
                                    receiver = personFive;
                                    break;
                                default:
                                    break;
                            }
                        }
                    } while (receiverOption < 1 || receiverOption > 5 || giverOption == receiverOption);

                    giver.TransferMoney(receiver, amountToSend);
                    giver.DisplayInfo();
                    receiver.DisplayInfo();
                }
            } while (giverOption != 0);
        }

        public void RunSimulation()
        {
            Console.WriteLine("Starting simulation");
            //TODO 5: Instantiate two Person objects, with unique names and money amounts. Two lines.
            Person dave = new Person("Dave", 500);
            Person jane = new Person("Jane", 300);

            //TODO 6: Call the .DisplayInfo() method on each person object, one at a time. This will show their initial money amount. Two lines.
            dave.DisplayInfo();
            jane.DisplayInfo();

            //TEST THE APPLICATION AFTER TODOS 5 AND 6!!

            //TODO 9: Call the .TransferMoney() method on one person object (giver), making sure to pass in the second person object (receiver), and the amount being transfered. One line.
            dave.TransferMoney(jane, 300);

            //TODO 10: Call the .DisplayInfo() method on each person object again, showing that each person's balance has changed. Two lines.
            dave.DisplayInfo();
            jane.DisplayInfo();


            // Bonus Stories: Add 3 additional Person objects, Provide the user a menu
            // The menu should allow the user to:
            // 1. Select any of the 5 people as a giver
            // 2. Select a transfer balance (Input an amount)
            // 3. Select a receiver/ recepient from one of the other people
            Person john = new Person("John", 800);
            Person lisa = new Person("Lisa", 600);
            Person jack = new Person("Jack", 100);

            menuBonusStory(dave, jane, john, lisa, jack);

            Console.WriteLine("Simulation complete.");
        }
    }
}
