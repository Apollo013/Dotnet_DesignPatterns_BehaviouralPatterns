using ChainOfReponsibilityPattern.Models;
using System;

namespace ChainOfReponsibilityPattern.Handlers
{
    public class Director : Approver
    {
        public override void ApproveProject(Project project)
        {
            if (project.Budget < 25000.0)
            {
                project.Approved = true;
                Console.WriteLine($"{this.GetType().Name} approved project: {project.Name}");
            }
            else
            {
                // Director not permitted to approve projects ov 25000, so must pass project up the chain to vice president
                Successor.ApproveProject(project);
            }
        }
    }
}
