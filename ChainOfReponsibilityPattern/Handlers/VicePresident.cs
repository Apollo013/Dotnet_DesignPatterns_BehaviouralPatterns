using ChainOfReponsibilityPattern.Models;
using System;

namespace ChainOfReponsibilityPattern.Handlers
{
    public class VicePresident : Approver
    {
        public override void ApproveProject(Project project)
        {
            if (project.Budget < 50000.0)
            {
                project.Approved = true;
                Console.WriteLine($"{this.GetType().Name} approved project: {project.Name}");
            }
            else
            {
                // Vice president not permitted to approve projects ov 25000, so must pass project up the chain to president
                Successor.ApproveProject(project);
            }
        }
    }
}
