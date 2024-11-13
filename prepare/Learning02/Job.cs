public class Job
{
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear;
    public int _endYear;

    public string DisplayJobInformation()
    {
        return $"{_jobTitle} at {_company} ({_startYear}-{_endYear})";
    }
}