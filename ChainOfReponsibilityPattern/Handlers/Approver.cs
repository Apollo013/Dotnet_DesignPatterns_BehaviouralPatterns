using ChainOfReponsibilityPattern.Models;

namespace ChainOfReponsibilityPattern.Handlers
{
    /// <summary>
    /// Represents the base 'Handler' used to approve projects
    /// </summary>
    public abstract class Approver
    {
        protected Approver Successor { get; private set; }

        public void SetSuccessor(Approver successor)
        {
            Successor = successor;
        }

        public abstract void ApproveProject(Project project);
    }
}
