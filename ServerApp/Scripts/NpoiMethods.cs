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

        public static int ParseContains(this XWPFTable tbl, string requiredString)
        {
            foreach (XWPFTableRow row in tbl.Rows)
            {
                foreach (XWPFTableCell cell in row.GetTableCells())
                {
                    foreach (XWPFParagraph p in cell.Paragraphs)
                    {
                        if (p.Contains(requiredString)) return tbl.Rows.IndexOf(row);
                    }
                }
            }
            return 999;
        }
    }
}