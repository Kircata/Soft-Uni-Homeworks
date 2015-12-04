package com.company;

import java.util.Scanner;

public class CountAllWords {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String[] words = scan.nextLine().split("[ ;:,.!?'-]+");
        System.out.println(words.length);
    }
}
