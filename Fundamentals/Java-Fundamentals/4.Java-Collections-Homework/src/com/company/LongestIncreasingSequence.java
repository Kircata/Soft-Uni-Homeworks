package com.company;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;


public class LongestIncreasingSequence {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String[] numbersStr = scan.nextLine().split("\\s+");
        List<Integer> currentSequence = new ArrayList<>();
        List<Integer> longestSequence = new ArrayList<>();
        for (int i = 0; i < numbersStr.length; i++) {
            int currentNumber = Integer.parseInt(numbersStr[i]);
            if (currentSequence.size() == 0
                    || currentSequence.get(currentSequence.size() -1) < currentNumber){
                currentSequence.add(currentNumber);
                continue;
            }
            if (currentSequence.size() > longestSequence.size()){
                longestSequence.clear();
                longestSequence.addAll(currentSequence);
            }
                System.out.println(currentSequence);
                currentSequence.clear();
                currentSequence.add(currentNumber);
        }
        if (currentSequence.size() > longestSequence.size()){
            longestSequence.clear();
            longestSequence.addAll(currentSequence);
        }
        System.out.println(currentSequence);
        System.out.printf("Longest: %s", longestSequence);
    }
}
