namespace CohesionAndCoupling.Utils
{
    using System;

    public static class FileUtils
    {
        public static string GetFileExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");
            CheckFileName(fileName, indexOfLastDot);
            string extension = fileName.Substring(indexOfLastDot + 1);

            return extension;
        }

        public static string GetFileNameWithoutExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");
            CheckFileName(fileName, indexOfLastDot);
            string extension = fileName.Substring(0, indexOfLastDot);

            return extension;
        }

        private static void CheckFileName(string fileName, int indexOfLastDot)
        {
            if (indexOfLastDot == -1)
            {
                throw new InvalidOperationException($"The file name you have entered is invalid: {fileName}");
            }
        }
    }
}
