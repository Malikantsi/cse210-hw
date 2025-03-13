public class Resume
{
    public string _employee;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_employee}");
        Console.WriteLine("Jobs:");
        
        foreach (Job job in _jobs)
        {
           
            job.DisplayJobDetails();
        }
    }
}
