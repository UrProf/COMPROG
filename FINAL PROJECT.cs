using System;
using FINAL_PROJECT;

public class Program
{
    static void Main(string[] args)
    {
        int[] viewedActivities = new int[11]; // Assuming a maximum of 11 unique activities
        int viewedCount = 0;
        bool continueViewing = true;

        while (continueViewing)
        {
            // Display menu
            ShowMenu();

            // Read user input
            Console.Write("\nPlease select which activity you want to view: ");
            string input = Console.ReadLine();
            Console.Clear();
            int selectedActivity;

            // Validate input
            if (int.TryParse(input, out selectedActivity))
            {
                if (selectedActivity >= 1 && selectedActivity <= 11)
                {                                                        
                    // Show the selected activity or exam
                    Console.WriteLine("\nYou are viewing Activity " + selectedActivity + "\n");
                    switch (selectedActivity)
                    {
                        case 1:
                            Activity1 activity1 = new Activity1();
                            activity1.run();
                            break;
                        case 2:
                            Activity2 Activity2 = new Activity2();
                            Activity2.run();
                            break;
                        case 3:
                            Activity3 Activity3 = new Activity3();
                            Activity3.run();
                            break;
                        case 4:
                            Activity4 Activity4 = new Activity4();
                            Activity4.run();
                            break;
                        case 5:
                            Activity5 Activity5 = new Activity5();
                            Activity5.run();
                            break;
                        case 6:
                            Activity6 Activity6 = new Activity6();
                            Activity6.run();
                            break;
                        case 7:
                            Activity7 Activity7 = new Activity7();
                            Activity7.run();
                            break;
                        case 8:
                            Activity8 Activity8 = new Activity8();
                            Activity8.run();
                            break;
                        case 9:
                            PrelimExam PrelimExam = new PrelimExam();
                            PrelimExam.run();
                            break;
                        case 10:
                            MidtermExam MidtermExam = new MidtermExam();
                            MidtermExam.run();
                            break;
                        case 11:
                            SemiFinalExam SemiFinalExam = new SemiFinalExam();
                            SemiFinalExam.run();
                            break;
                    }
                }

                // Add to the viewed list if not already viewed
                bool alreadyViewed = false;
                for (int i = 0; i < viewedCount; i++)
                {
                    if (viewedActivities[i] == selectedActivity)
                    {
                        alreadyViewed = true;
                        break;
                    }
                }
                if (!alreadyViewed)
                {
                    viewedActivities[viewedCount] = selectedActivity;
                    viewedCount++;
                }            

            else
                {
                    Console.WriteLine("Invalid Selection. Please select a number between 1 and 11.");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input. Please enter a number.");
            }
                // Prompt to continue
                Console.Write("\nDo you wish to continue? (Answer yes or no): ");
                continueViewing = Console.ReadLine().ToLower() == "yes";
                Console.Clear();
            }

            Console.WriteLine("You have viewed the following activities:\n");
            for (int i = 0; i < viewedCount; i++)
            {
                Console.WriteLine("Activity " + viewedActivities[i] + "\n");
            }
            Console.WriteLine("Program Ends \n");
        }

        static void ShowMenu()
        {
            Console.WriteLine("1. Activity No.1");
            Console.WriteLine("2. Activity No.2");
            Console.WriteLine("3. Activity No.3");
            Console.WriteLine("4. Activity No.4");
            Console.WriteLine("5. Activity No.5");
            Console.WriteLine("6. Activity No.6");
            Console.WriteLine("7. Activity No.7");
            Console.WriteLine("8. Activity No.8");
            Console.WriteLine("9. Prelim Exam");
            Console.WriteLine("10. Midterm Exam");
            Console.WriteLine("11. Semi Final Exam");
        }
    }
