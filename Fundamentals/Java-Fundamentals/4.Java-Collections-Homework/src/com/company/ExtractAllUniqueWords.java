package com.company;

import java.util.Scanner;
import java.util.Set;
import java.util.TreeSet;

public class ExtractAllUniqueWords {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String[] words = scan.nextLine().split("[ ;:,.!?'-]+");
        Set<String> uniqueWords = new TreeSet<>();
        for (String word : words){
            uniqueWords.add(word.toLowerCase());
        }
        for (String word : uniqueWords){
            System.out.printf("%s ", word);
        }
    }
}
