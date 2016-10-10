namespace ChainOfReponsibilityPattern.Models
{
    /// <summary>
    /// Project class that requires approval
    /// </summary>
    public class Project
    {
        public string Name { get; private set; }
        public double Budget { get; private set; }
        public bool Approved { get; set; } = false;

        public Project(string name, double budget)
        {
            Name = name;
            Budget = budget;
        }
    }
}
