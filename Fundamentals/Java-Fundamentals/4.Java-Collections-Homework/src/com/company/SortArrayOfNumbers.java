package com.company;

import java.util.Arrays;
import java.util.Scanner;

public class SortArrayOfNumbers {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int numberOfElements = scan.nextInt();
        int[] elementsArr = new int[numberOfElements];
        for (int i = 0; i < elementsArr.length; i++) {
            elementsArr[i] = scan.nextInt();
        }
        Arrays.sort(elementsArr);
        for(Integer num : elementsArr){
            System.out.printf("%d ",num);
        }
    }
}
