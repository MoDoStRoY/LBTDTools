using LBTDTools.ServerApp.Scripts;
using NPOI.XWPF.UserModel;

namespace LBTDTools.Extensions
{
    public static class XWPFRunExtensions
    {
        public static void Replace(this XWPFRun r, string input, string output)
        {
            r.SetText(NpoiMethods.ReplaceRun(r.GetText(0), input,
                output), 0);
        }
    }
}