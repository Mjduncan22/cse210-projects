using System;

class Program
{
    static void Main(string[] args)
    {
        string option = "";
        while (option != "4")
        {
            Console.WriteLine("Choose an activity:\n1. Breathing Activity\n2. Reflection Activity\n3. Listing Activity\n4. Quit\nEnter a number:");
            option = Console.ReadLine();
            if (option == "1")
            {
                Console.WriteLine("How long will the activity be?");
                int durationTime = int.Parse(Console.ReadLine());
                string descriptionBreathing = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
                Activity _activityB = new Activity("Breathing Activity", descriptionBreathing ,durationTime);
                
                _activityB.RunActivity();
            }
            if (option == "2")
            {
                Console.WriteLine("How long will the activity be?");
                int durationTime = int.Parse(Console.ReadLine());                
                string descriptionReflection = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                Activity _activityR = new Activity("Reflection Activity", descriptionReflection,durationTime);
                _activityR.RunActivity();
            }   
            if (option == "3")
            {
                Console.WriteLine("How long will the activity be?");
                int durationTime = int.Parse(Console.ReadLine());                
                string descriptionListing = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                Activity _activityL = new Activity("Listing Activity", descriptionListing ,durationTime);
                _activityL.RunActivity();

            }
            if (option == "4")
            {
                Console.Clear();
                break;
            }
        };
    }
}