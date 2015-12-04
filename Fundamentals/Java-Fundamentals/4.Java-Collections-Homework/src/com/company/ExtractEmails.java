package com.company;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class ExtractEmails {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String text = scan.nextLine();
        Pattern emailPattern = Pattern.compile("[A-Za-z]+[._-]*[A-Za-z]+@[A-Za-z]+[._-]*[A-Za-z]+\\.[A-Za-z]+");
        Matcher matchEmail = emailPattern.matcher(text);
        while (matchEmail.find()){
            System.out.println(matchEmail.group());
        }
    }
}
