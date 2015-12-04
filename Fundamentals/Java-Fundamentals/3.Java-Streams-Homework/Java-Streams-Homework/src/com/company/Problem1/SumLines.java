package com.company.Problem1;


import java.io.*;
import java.util.ArrayList;
import java.util.List;

public class SumLines {
    public static void main(String[] args) throws FileNotFoundException,IOException {
        ArrayList<Integer> outputResult = new ArrayList<>();
        try(BufferedReader bfr = new BufferedReader( new FileReader("F:\\Data Kiril\\SoftUni\\Courses\\Java Fundamentals\\Java-Streams-Homework\\resources\\sum_lines\\lines.txt")))
        {

            String inputLine;
            while((inputLine = bfr.readLine())!=null) {
                int currentSum = 0;
                for (int i = 0; i < inputLine.length(); i++) {
                    currentSum+=inputLine.charAt(i);
                }
                outputResult.add(currentSum);

            }
        }
        for (int i = 0; i < outputResult.size(); i++) {
            System.out.println(outputResult.get(i));
        }



    }
}
