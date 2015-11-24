package com.company;

import java.util.Scanner;

public class DecimalToBase7 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int number = scan.nextInt();
        StringBuilder numberInBaseSeven = new StringBuilder();
        while (number != 0){
            int remainder = number % 7;
            numberInBaseSeven.append(remainder);
            number = number / 7;
        }
        System.out.println(numberInBaseSeven.reverse());
    }
}
