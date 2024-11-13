public class Resume
{
    public string _name = "";
    public List<string> _jobs = new List<string>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}\nJobs:");
        if (_jobs.Count == 0)
        {
            Console.WriteLine("No jobs available.");
        }
        foreach (var _job in _jobs)
        {
            Console.WriteLine(_job);
        }

    }
}