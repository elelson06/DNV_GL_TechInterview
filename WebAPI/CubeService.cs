using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI
{
    public class CubeService
    {
        
        public void CreateCube(Position position, CubeDimensions dimensions)
        {
            Cube wcube = new Cube(position, dimensions);
        }
        public Position setCubePosition(double coordinateX, double coordinateY, double coordinateZ)
        {
            Position wposition = new Position(coordinateX, coordinateY, coordinateZ);
            return wposition;
        }
        public CubeDimensions setCubeDimensions(double height, double length, double width)
        {
            CubeDimensions wcubedimensions = new CubeDimensions(height, length, width);
            return wcubedimensions;
        }
        public Boolean cubesCollide(Cube cubeA, Cube cubeB)
        {
            // logic to get the position of the collision between cubeA and cubeB
            Boolean func_Intersect = true;
            //CubeA values
            double maxXcubeA = cubeA.Position.CoordinateX + (cubeA.Dimensions.Length / 2);
            double minXcubeA = cubeA.Position.CoordinateX - (cubeA.Dimensions.Length / 2);
            double maxYcubeA = cubeA.Position.CoordinateY + (cubeA.Dimensions.Height / 2);
            double minYcubeA = cubeA.Position.CoordinateY - (cubeA.Dimensions.Height / 2);
            double maxZcubeA = cubeA.Position.CoordinateZ + (cubeA.Dimensions.Width / 2);
            double minZcubeA = cubeA.Position.CoordinateZ - (cubeA.Dimensions.Width / 2);

            //CubeB values
            double maxXcubeB = cubeB.Position.CoordinateX + (cubeB.Dimensions.Length / 2);
            double minXcubeB = cubeB.Position.CoordinateX - (cubeB.Dimensions.Length / 2);
            double maxYcubeB = cubeB.Position.CoordinateY + (cubeB.Dimensions.Height / 2);
            double minYcubeB = cubeB.Position.CoordinateY - (cubeB.Dimensions.Height / 2);
            double maxZcubeB = cubeB.Position.CoordinateZ + (cubeB.Dimensions.Width / 2);
            double minZcubeB = cubeB.Position.CoordinateZ - (cubeB.Dimensions.Width / 2);

            if (maxXcubeA < minXcubeB)
                func_Intersect = false;
            else if (maxXcubeB < minXcubeA)
                func_Intersect = false;
            else if (maxYcubeA < minYcubeB)
                func_Intersect = false;
            else if (maxYcubeB < minYcubeA)
                func_Intersect = false;
            else if (maxZcubeA < minZcubeB)
                func_Intersect = false;
            else if (maxZcubeB < minZcubeA)
                func_Intersect = false;
            
            return func_Intersect;
        }
        public double getIntersectedVolume()
        {
            //logic to get the intersected volume of 2 cubes
            return 2*2*2;
        }
    }
}