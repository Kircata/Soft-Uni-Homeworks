package com.company;


import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class SortArrayWithStreamAPI {
    public static List<Integer> sortedList;
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String[] numbers = scan.nextLine().split("\\s+");
        String sortingOrder = scan.nextLine();
        switch (sortingOrder){
            case "Ascending":
                sortedList = Arrays.stream(numbers)
                        .map(Integer::parseInt)
                        .sorted((x,y) -> Integer.compare(x,y))
                        .collect(Collectors.toList());
                System.out.println(sortedList);
                break;
            case "Descending":
                sortedList = Arrays.stream(numbers)
                        .map(Integer::parseInt)
                        .sorted((x,y) -> Integer.compare(y,x))
                        .collect(Collectors.toList());
                System.out.println(sortedList);
                    break;
        }
    }
}
