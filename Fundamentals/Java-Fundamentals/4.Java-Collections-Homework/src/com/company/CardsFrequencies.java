package com.company;


import java.util.*;
import java.util.stream.Collectors;

public class CardsFrequencies {
    public static Map<String,Double> cardAndFrequency = new TreeMap<>();
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String[] playingCards = scan.nextLine().split("\\s");
        fillMap(playingCards);
        List<String> distinctCards = Arrays.stream(playingCards)
                .distinct()
                .collect(Collectors.toList());
        for (String card: distinctCards){
            System.out.printf("%s -> %.2f%%\n"
                    ,card.substring(0,card.length()-1)
                    ,(cardAndFrequency.get(card)/playingCards.length)*100);
        }
    }
    public static void fillMap (String[] cards){
        for (String playingCard: cards){
            Double frequency = cardAndFrequency.get(playingCard);
            if (frequency == null){
                frequency = 0.00;
            }
            cardAndFrequency.put(playingCard, frequency + 1);
        }
    }
}
