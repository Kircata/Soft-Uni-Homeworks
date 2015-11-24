package com.company;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class ExtractWords {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String text = scan.nextLine();
        Pattern wordPattern = Pattern.compile("[A-Za-z]+");
        Matcher matchWord = wordPattern.matcher(text);
        while(matchWord.find()){
            System.out.print(matchWord.group() + " ");
        }
        System.out.println();
    }
}
