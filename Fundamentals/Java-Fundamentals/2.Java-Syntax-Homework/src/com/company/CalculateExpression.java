package com.company;


import java.util.Locale;
import java.util.Scanner;

public class CalculateExpression {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        float a = scan.nextFloat();
        float b = scan.nextFloat();
        float c = scan.nextFloat();
        double f1 = Math.pow((a*a + b*b)/(a*a - b*b), (a+b+c) / Math.sqrt(c));
        double f2 = Math.pow(a*a + b*b - c*c*c, a-b);
        double diff = (f1+f2)/2 - (a+b+c)/3;
        System.out.printf("F1 result: %.2f; F2 result: %.2f; Diff: %.2f", f1,f2,diff);
    }
}
