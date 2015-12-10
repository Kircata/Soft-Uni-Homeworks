
import java.util.Scanner;

public class LettersChangeNumbers {
    public static double letterPosition;
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String[] sequenceOfStrings = scan.nextLine().split("\\s+");
        double totalSum = 0;
        for (int i = 0; i < sequenceOfStrings.length; i++) {
            char firstLetter = sequenceOfStrings[i].charAt(0);
            char secondLetter = sequenceOfStrings[i].charAt(sequenceOfStrings[i].length()-1);
            int numberBetween = Integer.parseInt(sequenceOfStrings[i].substring(1, sequenceOfStrings[i].length() - 1));
            double currentSum = numberBetween;
            if (Character.isUpperCase(firstLetter)){
                letterPosition = firstLetter -'A' +1;
                currentSum/=letterPosition;
            } else {
                letterPosition = firstLetter - 'a' +1;
                currentSum*=letterPosition;
            }
            if (Character.isUpperCase(secondLetter)){
                letterPosition = secondLetter - 'A' +1;
                currentSum-=letterPosition;
            } else {
                letterPosition = secondLetter - 'a' +1;
                currentSum+=letterPosition;
            }
            totalSum+=currentSum;
        }
        System.out.printf("%.2f",totalSum);
    }
}
