package com.company;


import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

public class MostFrequentWord {
    public static  Map<String,Integer> wordAndCount = new TreeMap<>();
    public static Integer maxValue = 0;
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String[] words = scan.nextLine().split("[ ;:,.!?'-]+");
        fillMap(words);
        for (Map.Entry keyValuePair : wordAndCount.entrySet()){
            if (keyValuePair.getValue() == maxValue){
                System.out.printf("%s -> %d times\n", keyValuePair.getKey(), keyValuePair.getValue());
            }
        }
    }
    public static void fillMap (String[] words){
        for (String word: words){
            Integer count = wordAndCount.get(word.toLowerCase());
            if (count == null){
                count = 0;
            }
            wordAndCount.put(word.toLowerCase(), count+1);
            if (count + 1 > maxValue){
                maxValue = count + 1;
            }
        }
    }
}
