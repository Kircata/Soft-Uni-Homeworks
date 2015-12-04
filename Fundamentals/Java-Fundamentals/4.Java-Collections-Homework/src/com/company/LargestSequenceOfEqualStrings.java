package com.company;

import java.util.ArrayList;
import java.util.Scanner;

public class LargestSequenceOfEqualStrings {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String[] sequence = scan.nextLine().split("\\s+");
        ArrayList<String> currentSequence = new ArrayList<String>(){{
            add(sequence[0]);
        }};
        ArrayList<String> largestSequence = new ArrayList<String>();
        for (int i = 1; i < sequence.length; i++) {
            if (sequence[i].equals(currentSequence.get(0))){
                currentSequence.add(sequence[i]);
            }else {
                if (currentSequence.size() > largestSequence.size()){
                    largestSequence = new ArrayList<String>(currentSequence);
                }
                currentSequence.clear();
                currentSequence.add(sequence[i]);
            }
        }
        if (currentSequence.size() > largestSequence.size()){
            largestSequence = new ArrayList<String>(currentSequence);
        }
        System.out.println(largestSequence);
    }
}
