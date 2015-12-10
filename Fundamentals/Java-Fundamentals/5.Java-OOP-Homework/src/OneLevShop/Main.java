package OneLevShop;


import OneLevShop.Products.Appliance;
import OneLevShop.Products.Computer;
import OneLevShop.Products.FoodProduct;
import OneLevShop.Products.Product;

import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.util.ArrayList;
import java.util.List;
import java.util.Locale;
import java.util.stream.Collectors;

public class Main {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);

        FoodProduct apple = new FoodProduct("Orange", 1.00, 155, AgeRestriction.None, LocalDate.parse("2015-08-21", DateTimeFormatter.ISO_LOCAL_DATE));
        FoodProduct cheese = new FoodProduct("Milk", 17.00, 1330, AgeRestriction.Adult, LocalDate.parse("2014-11-06", DateTimeFormatter.ISO_LOCAL_DATE));
        Appliance vacuum = new Appliance("Vacuum 2000X", 122.56, 3, AgeRestriction.Adult);
        Appliance drill = new Appliance("Power Drill 666Q", 220.22, 10, AgeRestriction.Adult);
        Computer hp = new Computer("HP 255 G2", 450.88, 10, AgeRestriction.Teenager);
        Computer lenovo = new Computer("Lenovo Tablet A", 758.45, 20, AgeRestriction.None);
        Computer lenovo2 = new Computer("Lenovo Fitness", 1024.24, 5, AgeRestriction.Adult);

        Customer goshko = new Customer("Goshko", 12, 45);
        Customer ivan = new Customer("Ivan Ivanov", 33, 1000);
        Customer pesho = new Customer("Pesho", 16, 1000);
        ArrayList<Product> products = new ArrayList<>();
        products.add(apple);
        products.add(cheese);
        products.add(vacuum);
        products.add(drill);
        products.add(hp);
        products.add(lenovo);
        products.add(lenovo2);
        List<Product> result = products.stream()
                .filter(p -> p.getRestriction() == AgeRestriction.Adult)
                .sorted((p1, p2) -> Double.compare(p1.getPrice(), p2.getPrice()))
                .collect(Collectors.toList());

        System.out.println("Search #1:");
        System.out.println(result);
    }


}
