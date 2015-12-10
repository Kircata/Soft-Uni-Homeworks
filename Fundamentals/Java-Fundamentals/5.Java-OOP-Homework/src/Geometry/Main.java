package Geometry;


import Geometry.ThreeDimensional.*;
import Geometry.TwoDimensional.*;

import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

public class Main {
    public static void main(String[] args) {
        Vertex2D pointA = new Vertex2D(2,1);
        Vertex2D pointB = new Vertex2D(3,2);
        Vertex2D pointC = new Vertex2D(13,4);

        Vertex3D pointD = new Vertex3D(1,3,5);

        Triangle triangle = new Triangle(pointA,pointB,pointC);
        Rectangle rectangle = new Rectangle(pointA,3,4);
        Circle circle = new Circle(pointA,7);

        SquarePyramid pyramid = new SquarePyramid(pointD,1,3);
        Cuboid cuboid = new Cuboid(pointD,5,7,11);
        Sphere sphere = new Sphere(pointD,12);

        ArrayList<Shape> shapes = new ArrayList<>();
        shapes.add(triangle);
        shapes.add(rectangle);
        shapes.add(circle);
        shapes.add(pyramid);
        shapes.add(cuboid);
        shapes.add(sphere);

        List<Shape> result = shapes.stream()
                .filter(s -> s instanceof SpaceShape)
                .map(s->(SpaceShape)s)
                .filter(s-> s.getVolume() > 40)
                .collect(Collectors.toList());

        List<Shape> result2 = shapes.stream()
                .filter(s->s instanceof PlaneShape)
                .sorted()
                .collect(Collectors.toList());
        System.out.println("Search #1:");
        System.out.println(result);
        System.out.println();
        System.out.println("Search #2:");
        System.out.println(result2);
    }
}
