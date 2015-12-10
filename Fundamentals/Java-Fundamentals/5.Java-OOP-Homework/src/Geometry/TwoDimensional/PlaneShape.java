package Geometry.TwoDimensional;

import Geometry.Interfaces.AreaMeasurable;
import Geometry.Interfaces.PerimeterMeasurable;
import Geometry.Interfaces.Vertex;
import Geometry.Shape;

import java.util.ArrayList;
import java.util.Arrays;


public abstract class PlaneShape extends Shape implements AreaMeasurable,PerimeterMeasurable,Comparable<PlaneShape>{
    protected PlaneShape(Vertex2D...vertices){
        super(new ArrayList<Vertex>(Arrays.asList(vertices)));
    }

    @Override
    public int compareTo(PlaneShape o) {
        return Double.compare(this.getPerimeter(), o.getPerimeter());
    }

    @Override
    public abstract String toString();
}
