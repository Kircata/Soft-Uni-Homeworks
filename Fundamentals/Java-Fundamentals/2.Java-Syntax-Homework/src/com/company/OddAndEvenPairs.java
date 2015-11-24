package com.company;


import java.util.Scanner;

public class OddAndEvenPairs {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String integers = scan.nextLine();
        int length = 0;
        for (String s : integers.split("\\s")) {
            length++;
        }
        int[] intArr = new int[length];
        int index = 0;
        if (length % 2 == 1){
            System.out.println("Invalid length");
        }
        else{
            for (String s : integers.split("\\s")) {
                intArr[index] = Integer.parseInt(s);
                index++;
            }
            for (int i = 0; i < intArr.length; i+=2) {
                int currentNumber = intArr[i];
                int nextNumber = intArr[i+1];
                if (currentNumber % 2 == 0
                        && nextNumber == 0){
                    System.out.printf("%d, %d -> both are even", currentNumber,nextNumber);
                }
                else if (currentNumber % 2 ==1
                            && nextNumber % 2 ==1){
                    System.out.printf("%d, %d -> both are odd", currentNumber,nextNumber);
                }
                else{
                    System.out.printf("%d, %d -> different", currentNumber,nextNumber);
                }
                System.out.println();
            }
        }


    }
}
