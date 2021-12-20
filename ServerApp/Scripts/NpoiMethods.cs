namespace LBTDTools.ServerApp.Scripts
{
    public class NpoiMethods
    {
        public static string ReplaceRun(string run, string oldString, string newString)
        {
            if (!string.IsNullOrEmpty(run) && run.Contains(oldString))
            {
                run = run.Replace(oldString, newString);
            }

            return run;
        }
    }
}