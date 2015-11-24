package com.company;


import java.util.Scanner;

public class SumNumbers {
    public static void main(String[] args){
        Scanner readInput = new Scanner(System.in);
        int inputNumber = Integer.parseInt(readInput.next());
        int sum = 0;
        for (int currentNumber = 1; currentNumber <= inputNumber; currentNumber++) {
            sum+=currentNumber;
        }
        System.out.println(sum);
    }
}
