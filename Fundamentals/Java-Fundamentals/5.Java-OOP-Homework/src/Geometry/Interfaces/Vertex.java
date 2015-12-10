package Geometry.Interfaces;


import Geometry.ThreeDimensional.Vertex3D;
import Geometry.TwoDimensional.Vertex2D;

public interface Vertex {
    double getX();
    double getY();
    double calculateDistance(Vertex2D other);
    double calculateDistance(Vertex3D other);
}
