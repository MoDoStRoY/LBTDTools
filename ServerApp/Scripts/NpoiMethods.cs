using System.Collections.Generic;
using NPOI.XWPF.UserModel;

namespace LBTDTools.ServerApp.Scripts
{
    public static class NpoiMethods
    {
        public static void Replace(this XWPFParagraph p, string oldString, string newString)
        {
            if (!string.IsNullOrEmpty(p.Text) && p.Text.Contains(oldString))
            {
                for (int i = 0; i < p.Runs.Count; i++)
                {
                    /*if (p.Runs[i].GetText(0).Contains(oldString))
                    {
                        p.Runs[i].ReplaceText(oldString, newString);
                    }
                    else if (p.Runs[i].GetText(0).Contains("{$") && i <= p.Runs.Count-3)
                    {
                        p.Runs[i].ReplaceText(p.Runs[i].GetText(0), "");
                        p.Runs[i+1].ReplaceText(p.Runs[i+1].GetText(0), newString);
                        p.Runs[i+2].ReplaceText(p.Runs[i+2].GetText(0), "");
                    }*/
                    
                    p.ReplaceText(oldString, newString);
                }
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

        public static void ParseReplace(this XWPFTable tbl, string[,] replaceMassive)
        {
            foreach (XWPFTableRow row in tbl.Rows)
            {
                foreach (XWPFTableCell cell in row.GetTableCells())
                {
                    foreach (XWPFParagraph p in cell.Paragraphs)
                    {
                        for (int i = 0; i < replaceMassive.GetLength(0); i++)
                        {
                            p.Replace(replaceMassive[i, 0], replaceMassive[i, 1]);
                        }
                    }
                }
            }
        }
        
        public static void ParseReplace(this IList<XWPFParagraph> paragraphs, string[,] stringsForReplace)
                {
                    for (int i = 0; i < paragraphs.Count; i++)
                    {
                        if (paragraphs[i].Text == "")
                            continue;

                        for (int i1 = 0; i1 < stringsForReplace.GetLength(0); i1++)
                            paragraphs[i].Replace(stringsForReplace[i1, 0], stringsForReplace[i1, 1]);
                    }
                }
    }
}