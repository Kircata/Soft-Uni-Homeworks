package com.company;


import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class ImplementRecursiveBinarySearch {
    public static int indexOfElement;
    public static List<Integer> numbersList;
    public static int elementToLookFor;
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        elementToLookFor = Integer.parseInt(scan.nextLine());
        String[] numbersArr = scan.nextLine().split(" ");
        numbersList = Arrays.stream(numbersArr)
                .map(Integer::parseInt)
                .collect(Collectors.toList());
        int currentPosition = numbersList.size() / 2;
        if (checkLeft(currentPosition)){
            System.out.println(indexOfElement);
        }else {
            currentPosition = numbersList.size() / 2;
            if (checkRight(currentPosition)){
                System.out.println(indexOfElement);
            }else{
                System.out.println("-1");
            }
        }
    }
    public static boolean checkLeft(int currentPosition){
        boolean hasElement = false;
        if (numbersList.indexOf(elementToLookFor) == currentPosition){
            indexOfElement = currentPosition;
            return hasElement = true;
        }
        if (currentPosition < 0){
            return hasElement = false;
        }
        currentPosition--;
        checkLeft(currentPosition);
        return hasElement;
    }
    public static boolean checkRight(int currentPosition){
        boolean hasElement = false;
        if (numbersList.indexOf(elementToLookFor) == currentPosition){
            indexOfElement = currentPosition;
            return hasElement = true;
        }
        if (currentPosition >= numbersList.size()){
            return hasElement = false;
        }
        currentPosition++;
        checkRight(currentPosition);
        return hasElement = true;
    }
}
