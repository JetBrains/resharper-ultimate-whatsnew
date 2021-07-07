namespace ReSharper20172CSharp.Navigation
{
    public class Navigation
    {
        public void Demo()
        {
            // 1. Exact matches
            // Use "Find Everywhere" (Ctrl+T) to find the type Service.
            // Entering Service -> lots of other things found
            // Entering "Service" (with the quotes) -> exact match

            // 2. Word order
            // Use "Find Everywhere" (Ctrl+T) to find the method that validates users.
            // We forgot what it's called!
            // Entering UserValid -> found
            // Entering ValidUser -> found
        }

        public void FindService()
        {
        }

        public void UserValid()
        {
        }
    }

    #region Because everyone likes regions to hide things...
    
    public class Service
    {
    }

    public class UserService
    {
    }

    public class IssueService
    {
    }

    public class WorkItemService
    {
    }

    #endregion
}