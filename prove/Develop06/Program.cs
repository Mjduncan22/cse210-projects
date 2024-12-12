using System;

class Program
{
    static void Main(string[] args)
    {
        string _option = "0";
        Tracker _activeTracker = new Tracker();
        while (_option != "9")
        {
            Console.Clear();
            Console.WriteLine($"Choose a option:\n1. Display score\n2. List goals\n3. Record an event\n4. Load default list\n5. Create new goal\n6. Load file\n7. Save file\n9. Quit");
            _option = Console.ReadLine();
            Console.Clear();
            if (_option == "1")
            {
                _activeTracker.DisplayUserScore();
            }
            if (_option == "2")
            {
                _activeTracker.DisplayGoalsProgress();
                Thread.Sleep(5000);
            }
            if (_option == "3")
            {
                int _optionGoal;
                _activeTracker.DisplayGoalsProgress();
                Console.WriteLine("\nWhich goal needs to be updated:");
                _optionGoal = int.Parse(Console.ReadLine());
                _activeTracker.Record(_optionGoal);
            }
            if (_option == "4")
            {
                Tracker _tracker = new Tracker();
                _tracker.CreateDefaultList();
                _activeTracker = _tracker;
            }
            if (_option == "5")
            {
                _activeTracker.CreateNewGoal();
            }
            if (_option == "6")
            {
                Console.WriteLine($"What is the name of the file?");
                string _fileName = Console.ReadLine();
                _activeTracker.LoadFromFile(_fileName);
            }
            if (_option == "7")
            {
                Console.WriteLine($"Choose a name for the file");
                string _fileName = Console.ReadLine();
                _activeTracker.SaveToFile(_fileName);
            }
            if (_option == "9")
            {
                break;
            }
        }
    }
}