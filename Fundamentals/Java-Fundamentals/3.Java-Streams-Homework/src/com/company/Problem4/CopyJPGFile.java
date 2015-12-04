package com.company;

import java.io.*;

public class CopyJPGFile {
    public static void main(String[] args) throws IOException {
        FileInputStream fis = new FileInputStream("F:\\Data Kiril\\SoftUni\\Courses\\Java Fundamentals\\Java-Streams-Homework\\resources\\copy_jpg_file\\myImage.jpg");
        FileOutputStream fos = new FileOutputStream("F:\\Data Kiril\\SoftUni\\Courses\\Java Fundamentals\\Java-Streams-Homework\\resources\\copy_jpg_file\\my-copied-picture.jpg");
        int byteContainer;
        while((byteContainer = fis.read())!=-1)
        {
            fos.write(byteContainer);
        }
        fis.close();
        fos.close();
    }
}
