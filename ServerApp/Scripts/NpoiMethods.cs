using System.Collections.Generic;
using NPOI.OpenXmlFormats.Wordprocessing;
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
                {
                    paragraphs[i].Replace(stringsForReplace[i1, 0], stringsForReplace[i1, 1]);
                }
            }
        }

        public static void ParseReplaceWrap(this XWPFTable tbl, string keyWord, List<string> listOfStrings)
        {
            for (int i = 0; i < listOfStrings.Count; i++)
            {
                foreach (XWPFTableRow row in tbl.Rows)
                {
                    foreach (XWPFTableCell cell in row.GetTableCells())
                    {
                        foreach (XWPFParagraph p in cell.Paragraphs)
                        { 
                            if (!string.IsNullOrEmpty(p.Text) && p.Text.Contains(keyWord))
                            {
                                for (int i1 = 0; i1 < p.Runs.Count; i1++)
                                {
                                    p.ReplaceText(keyWord, listOfStrings[i]); 
                                }
                            }
                        }
                    }
                }
                tbl.AddRow(new XWPFTableRow(new CT_Row(), tbl));
                tbl.Rows[tbl.NumberOfRows-1].CreateCell().AddParagraph().CreateRun().SetText(keyWord);
            }

            tbl.RemoveRow(tbl.NumberOfRows - 1);
        }
    }
}