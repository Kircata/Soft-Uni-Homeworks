package com.company;


import java.util.Random;
import java.util.Scanner;

public class RandomizeNumbers {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int firstNumber = scan.nextInt();
        int secondNumber = scan.nextInt();
        Random randomGenerator = new Random();
        if (firstNumber > secondNumber){
            for (int i = 0; i <= firstNumber-secondNumber ; i++) {
                int randomNumber = randomGenerator.nextInt(firstNumber-secondNumber)+secondNumber;
                System.out.print(randomNumber + " ");
            }
            System.out.println();
        }
        else if (secondNumber > firstNumber){
            for (int i = 0; i <= secondNumber - firstNumber ; i++) {
                int randomNumber = randomGenerator.nextInt(secondNumber - firstNumber)+firstNumber;
                System.out.print(randomNumber + " ");
            }
            System.out.println();
        }
        else{
            System.out.println(firstNumber);
        }
    }
}
