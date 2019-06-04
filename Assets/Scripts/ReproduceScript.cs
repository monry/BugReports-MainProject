using BugReports.TestProject;

namespace BugReports.MainProject
{
    public class ReproduceScript
    {
        public static void Buz()
        {
            SomeTestScript.Foo();
        }
    }
}