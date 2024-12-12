using System.Text.Json;
public class Tracker
{
    private int _score;
    private List<Goal> _goalsList;

    public Tracker()
    {
        _goalsList = new List<Goal>();
    }
    public Tracker(int score, List<Goal> goalsList)
    {
        _score = score;
        _goalsList = goalsList;
    }
    public void DisplayUserScore()
    {
        foreach (Goal goal in _goalsList)
        {
            _score += goal.GetPointsEarned();
        }
        Console.WriteLine($"You have {_score} points");
        Thread.Sleep(5000);
    }
    public void DisplayGoalsProgress()
    {
        Console.Clear();
        foreach (Goal goal in _goalsList)
        {
            Console.WriteLine($"{_goalsList.IndexOf(goal) + 1}: {goal.DisplayGoal()}");
        }
        Console.WriteLine("Success");
    }
    public void SaveToFile(string fileName)
    {
        var goals = new List<Dictionary<string, object>>();

        foreach (Goal goal in _goalsList)
        {
            var goalInfo = goal.SaveGoalToFile();
            goals.Add(goalInfo);
        }

        string json = JsonSerializer.Serialize(goals, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(fileName, json);
        Console.WriteLine("Goals successfully saved!");
        Thread.Sleep(5000);
    }
    public void LoadFromFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            string json = File.ReadAllText(fileName);
            var loadedGoals = JsonSerializer.Deserialize<List<Dictionary<string, object>>>(json);
                
            _goalsList.Clear();
            foreach (var goalDict in loadedGoals)
            {
                var type = goalDict["Type"].ToString();

                if (type == "Simple Goal")
                {
                    var name = goalDict["Name"].ToString();
                    var pointsValue = int.Parse(goalDict["Point Value"].ToString());
                    var pointsEarned = int.Parse(goalDict["Points Earned"].ToString());
                    var completed = goalDict["Completed"].ToString();
                    var goal = new SimpleGoal(name, pointsValue, completed, pointsEarned, type);
                    _goalsList.Add(goal);
                    _score += pointsEarned;
                }
                if (type == "Eternal Goal")
                {
                    var name = goalDict["Name"].ToString();
                    var pointsValue = int.Parse(goalDict["Point Value"].ToString());
                    var pointsEarned = int.Parse(goalDict["Points Earned"].ToString());
                    var timesCompleted = int.Parse(goalDict["Times Completed"].ToString());
                    var goal = new EternalGoal(name, pointsValue, timesCompleted, pointsEarned, type);
                    _goalsList.Add(goal);
                    _score += pointsEarned;
                }
                if (type == "Checklist Goal")
                {
                    var name = goalDict["Name"].ToString();
                    var pointsValue = int.Parse(goalDict["Point Value"].ToString());
                    var pointsEarned = int.Parse(goalDict["Points Earned"].ToString());
                    var timesCompleted = int.Parse(goalDict["Times Completed"].ToString());
                    var maxCompleted = int.Parse(goalDict["Max Completions"].ToString());
                    var bonus = int.Parse(goalDict["Bonus"].ToString());
                    var goal = new ChecklistGoal(name, pointsValue, pointsEarned, type, timesCompleted, maxCompleted, bonus);
                    _goalsList.Add(goal);
                    _score += pointsEarned;                        
                }
            }
            Console.WriteLine("Goals successfully loaded!");
            Thread.Sleep(5000);
        }
    }
    public void Record(int optionGoal)
    {
        foreach (Goal goal in _goalsList)
        {
            if ((_goalsList.IndexOf(goal) + 1) == optionGoal)
            {
                goal.RecordProgress();
            }
        }
    }
    public void CreateNewGoal()
    {
        Console.WriteLine("What type of goal is it:\n1. Simple Goal\n2. Checklist Goal\n3. Eternal Goal\nEnter a number:");
        string type = Console.ReadLine();

        if (type == "1")
        {
            Console.WriteLine("Enter goal name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter points value:");
            int pointsValue = int.Parse(Console.ReadLine());

            Goal newGoal = new SimpleGoal(name, pointsValue, "no", 0, "Simple Goal");
            _goalsList.Add(newGoal);
            newGoal.DisplayGoal();
            Console.WriteLine("Goal added");
            Thread.Sleep(5000);
        }
        if (type == "2")
        {
            Console.WriteLine("Enter goal name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter points value:");
            int pointsValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of completions needed to receive bonus points:");
            int maxTimesCompleted = int.Parse(Console.ReadLine());

            Console.WriteLine("Bonus point amount:");
            int bonus = int.Parse(Console.ReadLine());

            Goal newGoal = new ChecklistGoal(name, pointsValue, 0, "Checklist Goal", 0, maxTimesCompleted, bonus);
            _goalsList.Add(newGoal);
            newGoal.DisplayGoal();
            Console.WriteLine("Goal added");
            Thread.Sleep(5000);
        }
        if (type == "3")
        {
            Console.WriteLine("Enter goal name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter points value:");
            int pointsValue = int.Parse(Console.ReadLine());

            Goal newGoal = new EternalGoal(name, pointsValue, 0, 0, "Eternal Goal");
            _goalsList.Add(newGoal);
            newGoal.DisplayGoal();
            Console.WriteLine("Goal added");
            Thread.Sleep(5000);
        }
        else
        {
            Console.WriteLine("Other goal types are not yet implemented.");
        }
    }
    public void CreateDefaultList()
    {
        _goalsList = new List<Goal>
        {
            new SimpleGoal("Finish college",1000,"no",0, "Simple Goal"),
            new SimpleGoal("Organize a come follow me group",500,"no",0, "Simple Goal"),
            new SimpleGoal("Join a society",100,"no",0, "Simple Goal"),

            new EternalGoal("Attend church", 20, 0, 0, "Eternal Goal"),
            new EternalGoal("Attend the temple", 50, 0, 0, "Eternal Goal"),
            new EternalGoal("Read scriptures every day for a week", 50, 0, 0, "Eternal Goal"),
        
            new ChecklistGoal("Finish Daily Homework", 50, 0, "Checklist Goal", 0, 5, 100),
            new ChecklistGoal("Go the gym", 20, 0, "Checklist Goal", 0, 10, 100),
            new ChecklistGoal("Go on dates", 50, 0, "Checklist Goal", 0, 10, 500),
        };
        Console.Clear();
        Console.WriteLine("Success");
        Thread.Sleep(5000);
    }
}