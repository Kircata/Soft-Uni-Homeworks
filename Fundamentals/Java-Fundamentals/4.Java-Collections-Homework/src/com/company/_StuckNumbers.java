package com.company;

import java.util.Scanner;

public class _StuckNumbers {
    public static boolean hasPrinted;
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int arrLength = Integer.parseInt(scan.nextLine());
        int[] distinctList = new int[arrLength];
        for (int i = 0; i < distinctList.length; i++) {
            distinctList[i] = scan.nextInt();
        }
            for (int i = 0; i < distinctList.length; i++) {
                for (int j = 0; j < distinctList.length; j++) {
                    for (int k = 0; k < distinctList.length; k++) {
                        for (int l = 0; l < distinctList.length; l++) {
                             int a = distinctList[i];
                             int b = distinctList[j];
                             int c = distinctList[k];
                             int d = distinctList[l];
                             if (a !=b && a!=c && a!=d&&
                                     b!=c && b!=d && c!=d){
                                 String first = "" + a + b;
                                 String second = "" + c + d;
                                 if (first.equals(second)) {
                                     System.out.printf("%d|%d==%d|%d\n",
                                             a, b, c, d);
                                     hasPrinted = true;
                                 }
                             }
                        }
                    }
                }
            }
           if (!hasPrinted){
            System.out.println("No");
           }
    }




}
