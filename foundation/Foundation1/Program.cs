using System;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video();
        List<(string name, string text)> commentList = new List<(string, string)>()
        {
            ("Sally John", "You are nice"),
            ("Jim Bob", "You are not nice"),
            ("Joe Tim", "Not cool bro")
        };
        v1.VideoDetails("Hello World","Michael Jordan",2020, commentList);
        v1.GetNumComments();
        v1.DisplayDetails();
        Console.WriteLine("");

        Video v2 = new Video();
        List<(string name, string text)> commentList2 = new List<(string, string)>()
        {
            ("Alice Jane", "Amazing content!"),
            ("Tom Jerry", "Very helpful."),
            ("Sarah Lee", "Keep it up!")
        };
        v2.VideoDetails("Learning how to smile", "Jane Minter", 52001, commentList2);
        v2.GetNumComments();
        v2.DisplayDetails();
        Console.WriteLine("");

        // Video 3
        Video v3 = new Video();
        List<(string name, string text)> commentList3 = new List<(string, string)>()
        {
            ("Mark Twain", "Excellent tutorial."),
            ("John Smith", "Good explanation."),
            ("Emily Rose", "Loved it!")
        };
        v3.VideoDetails("Killing Time", "James Topendude",11111, commentList3);
        v3.GetNumComments();
        v3.DisplayDetails();
        Console.WriteLine("");
    }
}