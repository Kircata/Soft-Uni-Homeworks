package com.company;

import java.util.Scanner;

public class PrintCharTriangle {
    public static void main(String[] args){
        Scanner readNumber = new Scanner(System.in);
        int inputNumber = Integer.parseInt(readNumber.next());
        for (int i = 1; i <= inputNumber; i++) {
            for (int j = 0; j < i; j++) {
                System.out.print((char) (97 + j) + " ");
            }
            System.out.println();
        }
        for (int i = inputNumber -1; i >=0; i--) {
            for (int j = 0; j < i; j++) {
                System.out.print((char) (97 + j) + " ");
            }
            System.out.println();
        }
        // Test to integers up to 26, because the english alphabet has 26 letters only.
    }
}
