using System;
using FINAL_PROJECT;
using System.Collections.Generic;

namespace FinalProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> viewedActivities = new List<int>();
            bool continueViewing = true;

            while (continueViewing)
            {
                // Display menu
                ShowMenu();

                // Read user input
                Console.Write("\nPlease select which activity you want to view: ");
                string input = Console.ReadLine(); Console.Clear();
                int selectedActivity;

                // Validate input
                if (int.TryParse(input, out selectedActivity) && selectedActivity >= 1 && selectedActivity <= 11)
                {
                    // Check if the activity has already been viewed
                    if (!viewedActivities.Contains(selectedActivity))
                    {
                        // Add to the viewed list
                        viewedActivities.Add(selectedActivity);

                        // Show the selected activity or exam
                        Console.WriteLine("\nYou are viewing Activity" + (selectedActivity) + "\n");
                        switch (selectedActivity)
                        {
                            case 1:
                                Activity1 Activity1 = new Activity1();
                                Activity1.run();
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
                    else
                    {
                        Console.WriteLine("You have already viewed this activity.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }

                // Prompt to continue
                Console.Write("\nDo you wish to continue? (Answer yes or no): ");
                continueViewing = Console.ReadLine().ToLower() == "yes";
                Console.Clear();
            }

            Console.WriteLine("You have viewed the following activities:\n");
            foreach (var activity in viewedActivities)
            {
                Console.WriteLine("Activity"+ (activity) + "\n");
            }
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

        static void ActivityNo1()
        {
            Console.WriteLine("Activity 1 coding:");
            // Activity 1 code here
        }

        static void ActivityNo2()
        {
            Console.WriteLine("Activity 2 coding:");
            // Activity 2 code here
        }

        static void ActivityNo3()
        {
            Console.WriteLine("Activity 3 coding:");
            //  3 code here
        }

        static void ActivityNo4()
        {
            Console.WriteLine("Activity 4 coding:");
            // 4 code here
        }

        static void ActivityNo5()
        {
            Console.WriteLine("Activity 5 coding:");
            // Activity 5 code here
        }

        static void ActivityNo6()
        {
            Console.WriteLine("Activity 6 coding:");
            // Activity 6 code here
        }

        static void ActivityNo7()
        {
            Console.WriteLine("Activity 7 coding:");
            // Activity 7 code here
        }

        static void ActivityNo8()
        {
            Console.WriteLine("Activity 8 coding:");
            // Activity 8 code here
        }

        static void PrelimExam()
        {
            Console.WriteLine("Prelim Exam coding:");
            // Prelim Exam code here
        }

        static void MidtermExam()
        {
            Console.WriteLine("Midterm Exam coding:");
            // Midterm Exam code here
        }

        static void SemiFinalExam()
        {
            Console.WriteLine("Semi Final Exam coding:");
            // Semi Final Exam code here
        }
    }
}
