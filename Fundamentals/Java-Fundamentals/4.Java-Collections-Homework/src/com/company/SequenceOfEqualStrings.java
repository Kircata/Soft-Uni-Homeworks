package com.company;

import java.util.ArrayList;
import java.util.Scanner;

public class SequenceOfEqualStrings {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String[] sequence = scan.nextLine().split("\\s+");
        ArrayList<String> currentSequence = new ArrayList<String>(){{
            add(sequence[0]);
        }};
        for (int i = 1; i < sequence.length; i++) {
            if (sequence[i].equals(currentSequence.get(0))){
                currentSequence.add(sequence[i]);
            }else {
                System.out.println(currentSequence);
                currentSequence.clear();
                currentSequence.add(sequence[i]);
            }
        }
        System.out.println(currentSequence);
    }
}
