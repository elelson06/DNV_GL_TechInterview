using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Domain.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double height = 10.5;
            double length = 4.2;
            double width = 22.7;

            double coordX = 2.5;
            double coordY = 1.2;
            double coordZ = 0.9;


            CubeDimensions wdimensions = new CubeDimensions(height, length, width);
            Position wposition = new Position(coordX, coordY, coordZ);
            Cube wcube = new Cube(wposition, wdimensions);
            Console.WriteLine("Position(X: " + wcube.Position.CoordinateX.ToString() + ";Y: " + wcube.Position.CoordinateY.ToString() + ";Z: " + wcube.Position.CoordinateZ.ToString() + ")");
            Console.WriteLine("Dimensions(H: " + wcube.Dimensions.Height.ToString() + ";L: " + wcube.Dimensions.Length.ToString() + ";W: " + wcube.Dimensions.Width.ToString() + ")");

        }
    }
}
