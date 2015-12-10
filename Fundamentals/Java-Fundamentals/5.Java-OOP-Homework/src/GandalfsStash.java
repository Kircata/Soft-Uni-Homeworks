
import java.util.Scanner;

public class GandalfsStash {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int currentPoints = Integer.parseInt(scan.nextLine());
        String[] foods = scan.nextLine().split("[^A-Za-z]+");
        for (int i = 0; i < foods.length; i++) {
            String currentFood = foods[i].toLowerCase();
            switch (currentFood){
                case "cram": currentPoints+=2; break;
                case "lembas": currentPoints+=3; break;
                case "apple": currentPoints+=1; break;
                case "melon": currentPoints+=1; break;
                case "honeycake": currentPoints+=5; break;
                case "mushrooms": currentPoints-=10; break;
                default: currentPoints-=1; break;
            }
        }
        if (currentPoints < -5){
            System.out.printf("%d\nAngry",currentPoints);
        } else if (currentPoints >=-5
                && currentPoints <0){
            System.out.printf("%d\nSad",currentPoints);
        } else if (currentPoints >=0
                && currentPoints<15){
            System.out.printf("%d\nHappy",currentPoints);
        } else {
            System.out.printf("%d\nSpecial JavaScript mood",currentPoints);
        }
    }
}
