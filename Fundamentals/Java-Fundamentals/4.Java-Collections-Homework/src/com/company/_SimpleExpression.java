package com.company;


import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class _SimpleExpression {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String arithmeticExpression = scan.nextLine();
        String[] digits = arithmeticExpression.split("[^\\d\\.]+");
        String[] signs = arithmeticExpression.split("[^\\+\\-]+");
        List<String> digitsList = removeEmptyEntries(digits);
        List<String> signsList = removeEmptyEntries(signs);
        int signsListIndex = 0;
        BigDecimal sum = new BigDecimal(digitsList.get(0));
        for (int digitListIndex = 1; digitListIndex < digitsList.size(); digitListIndex++, signsListIndex++) {
            BigDecimal currentNumber = new BigDecimal(digitsList.get(digitListIndex));
            switch (signsList.get(signsListIndex)){
                case "+": sum = sum.add(currentNumber); break;
                case "-": sum = sum.subtract(currentNumber); break;
            }
        }
        System.out.println(sum.toString());

    }
    public static List<String> removeEmptyEntries(String[] arr){
        List<String> listWithoutEmptyEntries = new ArrayList<>();
        for (int i = 0; i < arr.length; i++) {
            if (!arr[i].equals("")){
                listWithoutEmptyEntries.add(arr[i]);
            }
        }
        return  listWithoutEmptyEntries;
    }
}
