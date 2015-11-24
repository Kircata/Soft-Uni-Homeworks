package com.company;

import java.util.Scanner;

public class GetAverage {
    public static void main(String[] args){
        Scanner numbersScanner = new Scanner(System.in);
        double a = Double.parseDouble(numbersScanner.nextLine());
        double b = Double.parseDouble(numbersScanner.nextLine());
        double c = Double.parseDouble(numbersScanner.nextLine());
        double average = returnAverage(a,b,c);
        System.out.printf("%.2f", average);
    }
    public static double returnAverage(double firstNumber, double secondNumber, double thirdNumber){
        double average = (firstNumber + secondNumber + thirdNumber) / 3;
        return average;
    }
}
