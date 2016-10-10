using ChainOfReponsibilityPattern.Handlers;
using ChainOfReponsibilityPattern.Models;

namespace ChainOfReponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Project projectX = new Project("Project X", 24000);
            Project projectY = new Project("Project Y", 48000);
            Project projectZ = new Project("Project Z", 79000);

            Approver director = new Director();
            Approver vp = new VicePresident();
            Approver pres = new President();

            director.SetSuccessor(vp);
            vp.SetSuccessor(pres);

            director.ApproveProject(projectX);  // Will be approved by the director
            director.ApproveProject(projectY);  // Will be approved by the VP
            director.ApproveProject(projectZ);  // Will be approved by the President
        }
    }
}
