using System.IO;
class CopyBinaryFile
{
    static void Main()
    {
        FileStream imgToCopy = new FileStream("../../RickGrimes.jpg", FileMode.Open);
        FileStream newImg = new FileStream("../../NewRickGrimes.jpg", FileMode.Create);
        using (imgToCopy)
        {
            using (newImg)
            {
                byte[] buffer = new byte[4096];
                while (true)
                {
                    int readBytes = imgToCopy.Read(buffer, 0, buffer.Length);
                    if (readBytes == 0)
                    {
                        break;
                    }
                    else
                    {
                        newImg.Write(buffer, 0, readBytes);
                    }
                }
            }
        }
    }
}

