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
        
        public static void Replace(this XWPFParagraph p, string oldString, string newString)
        {
            if (!string.IsNullOrEmpty(p.Text) && p.Text.Contains(oldString))
            {
                p.ReplaceText(p.Text, p.Text.Replace(oldString, newString));
            }
        }

        public static bool Contains(this XWPFParagraph p, string requireString)
        {
            if (!string.IsNullOrEmpty(p.Text) && p.Text.Contains(requireString))
            {
                return true;
            }
            return false;
        }
    }
}