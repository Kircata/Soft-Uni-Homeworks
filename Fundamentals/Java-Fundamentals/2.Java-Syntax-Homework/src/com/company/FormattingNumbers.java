package com.company;

import java.util.Scanner;

public class FormattingNumbers {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int a = Integer.parseInt(scan.nextLine());
        float b = Float.parseFloat(scan.nextLine());
        float c = Float.parseFloat(scan.nextLine());
        String aToHex = Integer.toHexString(a).toUpperCase();
        String aToBinary = Integer.toBinaryString(a);
        System.out.printf( "|%-10s|%10s|%10.2f|%-10.3f|",
                aToHex,
                String.format("%10s", aToBinary).replace(' ', '0'),
                b,
                c);

    }
}
