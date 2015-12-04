package com.company.Problem5;

import java.io.*;
import java.util.ArrayList;

public class SaveListOfDoubles {
    public static void main(String[] args) throws IOException, ClassNotFoundException {
        ObjectOutputStream oos = new ObjectOutputStream( new FileOutputStream(
                "F:\\Data Kiril\\SoftUni\\Courses\\Java Fundamentals\\Java-Streams-Homework\\resources\\list_of_doubles\\doubles.list"));
        ArrayList<Double> doubles = new ArrayList<>();
        doubles.add(5.6);
        doubles.add(45.6);
        doubles.add(3.46);
        oos.writeObject(doubles);
        oos.flush();
        ObjectInputStream ois = new ObjectInputStream(
                new FileInputStream("F:\\Data Kiril\\SoftUni\\Courses\\Java Fundamentals\\Java-Streams-Homework\\resources\\list_of_doubles\\doubles.list"));
        System.out.println(ois.readObject());
        ois.close();


    }
}
