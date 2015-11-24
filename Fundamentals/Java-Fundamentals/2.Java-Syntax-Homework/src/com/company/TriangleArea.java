package com.company;


import java.util.Scanner;

public class TriangleArea {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int x1 = scan.nextInt();
        int y1 = scan.nextInt();
        int x2 = scan.nextInt();
        int y2 = scan.nextInt();
        int x3 = scan.nextInt();
        int y3 = scan.nextInt();
        double a = Math.sqrt(Math.pow(x2-x1,2) + Math.pow(y2-y1,2));
        double b = Math.sqrt(Math.pow(x3-x1,2) + Math.pow(y3-y1,2));
        double c = Math.sqrt(Math.pow(x3-x2,2) + Math.pow(y3-y2,2));
        if(a + b <= c
            || a + c <= b
            || b + c <= a){
            System.out.println("0");
        }
        else{
            double semiPerimeter = (a+b+c) / 2;
            double area = Math.sqrt(semiPerimeter*(semiPerimeter-a)*(semiPerimeter-b)*(semiPerimeter -c));
            System.out.println(Math.round(area));
        }
    }
}
