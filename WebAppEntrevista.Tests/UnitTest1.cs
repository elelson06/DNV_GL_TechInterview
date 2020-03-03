using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using WebAPI;

namespace WebAppEntrevista.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double HeightCubeA = 10.5;
            double LengthCubeA = 4.2;
            double WidthCubeA = 22.7;

            double CoordXCubeA = 2;
            double CoordYCubeA = 2;
            double CoordZCubeA = 2;

            double HeightCubeB = 10.5;
            double LengthCubeB = 4.2;
            double WidthCubeB = 22.7;

            double CoordXCubeB = 10;
            double CoordYCubeB = 10;
            double CoordZCubeB = 10;

            CubeService wservice = new CubeService();

            Position wpositionCubeA = wservice.setCubePosition(CoordXCubeA,CoordYCubeA, CoordZCubeA);
            CubeDimensions wdimensionCubeA = wservice.setCubeDimensions(HeightCubeA,LengthCubeA,WidthCubeA);
            Cube wcubeA = new Cube(wpositionCubeA, wdimensionCubeA);

            Console.WriteLine("Cube A");
            Console.WriteLine("Position(X: " + wcubeA.Position.CoordinateX.ToString() + ";Y: " + wcubeA.Position.CoordinateY.ToString() + ";Z: " + wcubeA.Position.CoordinateZ.ToString() + ")");
            Console.WriteLine("Dimensions(H: " + wcubeA.Dimensions.Height.ToString() + ";L: " + wcubeA.Dimensions.Length.ToString() + ";W: " + wcubeA.Dimensions.Width.ToString() + ")");

            Console.WriteLine("");

            Position wpositionCubeB = wservice.setCubePosition(CoordXCubeB, CoordYCubeB, CoordZCubeB);
            CubeDimensions wdimensionCubeB = wservice.setCubeDimensions(HeightCubeB,LengthCubeB, WidthCubeB);
            Cube wcubeB = new Cube(wpositionCubeB, wdimensionCubeB);

            Console.WriteLine("Cube B");
            Console.WriteLine("Position(X: " + wcubeB.Position.CoordinateX.ToString() + ";Y: " + wcubeB.Position.CoordinateY.ToString() + ";Z: " + wcubeB.Position.CoordinateZ.ToString() + ")");
            Console.WriteLine("Dimensions(H: " + wcubeB.Dimensions.Height.ToString() + ";L: " + wcubeB.Dimensions.Length.ToString() + ";W: " + wcubeB.Dimensions.Width.ToString() + ")");

            Console.WriteLine("");

            if (wservice.cubesCollide(wcubeA, wcubeB))
                Console.WriteLine("The cubes Collide!");
            else
                Console.WriteLine("The cubes does not Collide!");
        }
    }
}
