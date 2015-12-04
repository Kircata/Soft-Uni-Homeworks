package com.company;

import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class FilterArray {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String[] words = scan.nextLine().split("[ ;:,.!?'-]+");
        List<String> filteredWords = Arrays.stream(words)
                .filter(word -> word.length() > 3)
                .collect(Collectors.toList());
        for (String word: filteredWords){
            System.out.printf("%s ", word);
        }
        if (filteredWords.size() == 0){
            System.out.println("(empty)");
        }
    }
}
