package com.company;


import java.util.Scanner;

public class HitTheTarget {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int target = scan.nextInt();
        int[] intArr = new int[20];
        int numberToFill = 1;
        for (int i = 0; i < intArr.length; i++, numberToFill++) {
            intArr[i] = numberToFill;
        }
        for (int i = 0; i < intArr.length; i++) {
            int currentNumber = intArr[i];
            for (int j = 0; j < intArr.length; j++) {
                int addend = intArr[j];
                if (currentNumber + addend == target) {
                    System.out.printf("%d + %d = %d", currentNumber, addend, target);
                    System.out.println();
                }
                if (currentNumber - addend == target) {
                    System.out.printf("%d - %d = %d", currentNumber, addend, target);
                    System.out.println();
                }
                if (addend - currentNumber == target) {
                    System.out.printf("%d - %d = %d", addend, currentNumber, target);
                    System.out.println();
                }

            }
        }
    }
}
