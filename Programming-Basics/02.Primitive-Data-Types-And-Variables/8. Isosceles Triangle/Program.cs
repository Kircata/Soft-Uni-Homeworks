using System;
    class CopyrightPyramid
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            char symbolCopyright = '\u00A9';
            Console.WriteLine("   {0}\n  {1} {2}\n {3}   {4}\n{5} {6} {7} {8}"
            ,symbolCopyright
            ,symbolCopyright
            ,symbolCopyright
            ,symbolCopyright
            ,symbolCopyright
            ,symbolCopyright
            ,symbolCopyright
            ,symbolCopyright
            ,symbolCopyright);
        }
    }

