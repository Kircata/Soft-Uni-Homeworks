package com.company;

import java.util.Scanner;

public class RectangleArea {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int firstSide = scan.nextInt();
        int secondSide = scan.nextInt();
        System.out.println(firstSide * secondSide);
    }
}
