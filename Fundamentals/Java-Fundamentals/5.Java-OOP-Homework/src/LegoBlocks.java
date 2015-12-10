

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class LegoBlocks {
    public static int N;
    public static Scanner scan;
    public static List<Character> outputList = new ArrayList<>();
    public static int elementsCount = 0;
    public static void main(String[] args) {
        scan = new Scanner(System.in);
        N = Integer.parseInt(scan.nextLine());
        char[][] firstMatrix = new char[N][];
        char[][] secondMatrix = new char[N][];
        fillMatrix(firstMatrix);
        fillMatrix(secondMatrix);
        int initialLength = firstMatrix[0].length + secondMatrix[0].length;
        if (checkLength(firstMatrix,secondMatrix,initialLength)){
            fillAndPrintList(firstMatrix,secondMatrix);
        } else {
            System.out.printf("The total number of cells is: %d",elementsCount);
        }
    }
    public static void fillMatrix(char[][] matrix){
        for (int i = 0; i < N; i++) {
            String inputNumbers = scan.nextLine().trim();
            inputNumbers = inputNumbers.replaceAll("\\s+"," ");
            String[] realInputNumbers = inputNumbers.split(" ");
            elementsCount+=realInputNumbers.length;
            inputNumbers = inputNumbers.replaceAll("\\s+","");
            matrix[i] = inputNumbers.toCharArray();
        }
    }
    public static boolean checkLength(char[][] firstMatrix,char[][] secondMatrix,int initialLength){
        boolean isRectangularMatrix = true;
        for (int i = 1; i < firstMatrix.length; i++) {
            int currentLength = firstMatrix[i].length + secondMatrix[i].length;
            if (currentLength != initialLength){
                isRectangularMatrix = false;
                break;
            }
        }
        return isRectangularMatrix;
    }
    public static void fillAndPrintList (char[][]firstMatrix, char[][]secondMatrix){
        for (int i = 0; i < N; i++) {
            int length = firstMatrix[i].length + secondMatrix[i].length;
            int secondMatrixLength = secondMatrix[i].length-1;
            for (int j = 0; j < length; j++) {
                if (j < firstMatrix[i].length){
                    outputList.add(firstMatrix[i][j]);
                } else {
                    outputList.add(secondMatrix[i][secondMatrixLength]);
                    secondMatrixLength--;
                }
            }
            System.out.println(outputList);
            outputList.clear();
        }
    }
}
