package com.company;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class StartsAndEndsWithCapitalLetter {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String text = scan.nextLine();
        Pattern wordPattern = Pattern.compile("\\b[A-Z][A-Za-z]*[A-Z]\\b");
        Matcher matchWord = wordPattern.matcher(text);
        while(matchWord.find()){
            System.out.print(matchWord.group() + " ");
        }
        System.out.println();
    }
}
