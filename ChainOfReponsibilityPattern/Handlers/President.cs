using ChainOfReponsibilityPattern.Models;
using System;

namespace ChainOfReponsibilityPattern.Handlers
{
    public class President : Approver
    {
        public override void ApproveProject(Project project)
        {
            if (project.Budget < 100000.0)
            {
                project.Approved = true;
                Console.WriteLine($"{this.GetType().Name} approved project: {project.Name}");
            }
            else
            {
                Console.WriteLine($"Project {project.Name} requires an executive meeting!");
            }
        }
    }
}
