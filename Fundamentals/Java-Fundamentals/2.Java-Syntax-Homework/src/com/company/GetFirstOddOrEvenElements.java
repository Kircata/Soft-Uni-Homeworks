package com.company;


import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class GetFirstOddOrEvenElements {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        List<Integer> listOfElements = new ArrayList<Integer>();
        fillList(scan,listOfElements);
        String[] tokens = scan.nextLine().split(" ");
        int numberOfElementsToGet = Integer.parseInt(tokens[1]);
        String oddOrEven = tokens[2];
        switch(oddOrEven){
            case "odd": getOddElemets(listOfElements,numberOfElementsToGet);
                break;
            case "even": getEvenElements(listOfElements,numberOfElementsToGet);
                break;
        }

    }
    static void fillList(Scanner scan , List<Integer> listOfElements)
    {
        String[] numbersArr = scan.nextLine().split(" ");
        for (int i = 0; i < numbersArr.length; i++) {
            listOfElements.add(Integer.parseInt(numbersArr[i]));
        }
    }
    static void getEvenElements(List<Integer> listOfElements, int numberOfElementsToGet){
        int counter =0;
        for (int i = 0; i < listOfElements.size(); i++) {
            if(listOfElements.get(i) % 2 == 0) {
                System.out.print(listOfElements.get(i) + " ");
                counter++;
            }
            if(counter >= numberOfElementsToGet) {
                break;
            }
        }
    }
    static void getOddElemets(List<Integer> listOfElements, int numberOfElementsToGet){
        int counter =0;
        for (int i = 0; i < listOfElements.size(); i++) {
            if(listOfElements.get(i) % 2 == 1) {
                System.out.print(listOfElements.get(i) + " ");
                counter++;
            }
            if(counter >= numberOfElementsToGet) {
                break;
            }
        }
    }
}
