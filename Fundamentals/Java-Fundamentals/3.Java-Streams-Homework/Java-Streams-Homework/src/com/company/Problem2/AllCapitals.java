package com.company;

import java.io.*;
public class AllCapitals {
    public static void main(String[] args) throws IOException {

        BufferedReader bfr = new BufferedReader(
                new FileReader(
                        "F:\\Data Kiril\\SoftUni\\Courses\\Java Fundamentals\\Java-Streams-Homework\\resources\\all_capitals\\lines.txt"));
        String fullText = "";
        String tempStr;

        while ((tempStr = bfr.readLine()) != null) {
            fullText += tempStr.toUpperCase() + "\r\n";
        }

        PrintWriter prw = new PrintWriter(
                new BufferedWriter(
                        new FileWriter(
                                "F:\\Data Kiril\\SoftUni\\Courses\\Java Fundamentals\\Java-Streams-Homework\\resources\\all_capitals\\lines.txt")));
        prw.write(fullText);
        prw.flush();
        bfr.close();
        prw.close();

    }
}