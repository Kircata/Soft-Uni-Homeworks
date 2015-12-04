package com.company;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class CombineListOfLetters {

    public static Scanner scan = new Scanner(System.in);
    public static List<Character> firstList = new ArrayList<>();
    public static List<Character> secondList = new ArrayList<>();
    public static List<Character> outputList = new ArrayList<>();

    public static void main(String[] args) {
         fillList(firstList);
         fillList(secondList);
         fillOutputList();
         for (char el : outputList){
             System.out.printf("%c ", el);
         }
    }
    public static void fillList(List<Character> list){
        String currentInfo = scan.nextLine();
        for (int index = 0; index < currentInfo.length(); index++) {
            if (currentInfo.charAt(index) != ' '){
                list.add(currentInfo.charAt(index));
            }
        }
    }
    public static void fillOutputList (){
        outputList.addAll(firstList);
        for (int index = 0; index < secondList.size() ; index++) {
            if (!firstList.contains(secondList.get(index))){
                outputList.add(secondList.get(index));
            }
        }
    }

}
