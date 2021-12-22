using NPOI.XWPF.UserModel;

namespace LBTDTools.ServerApp.Scripts
{
    public static class NpoiMethods
    {
        public static void Replace(this XWPFRun r, string oldString, string newString)
        {
            if (!string.IsNullOrEmpty(r.GetText(0)) && r.GetText(0).Contains(oldString))
            {
                r.SetText(r.GetText(0).Replace(oldString, newString), 0);
            }
        }

        public static bool Contains(this XWPFRun r, string requireString)
        {
            if (!string.IsNullOrEmpty(r.GetText(0)) && r.GetText(0).Contains(requireString))
            {
                return true;
            }
            return false;
        }
    }
}