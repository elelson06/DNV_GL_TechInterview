using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domain
{
    public class Cube
    {
        private int id;
        private Position position;
        private CubeDimensions dimensions;

        public Position Position
        {
            get
            {
                return position;
            }

            set
            {
                position = value;
            }
        }

        public CubeDimensions Dimensions
        {
            get
            {
                return dimensions;
            }

            set
            {
                dimensions = value;
            }
        }

        public Cube(Position position, CubeDimensions dimensions)
        {
            this.position = position;
            this.dimensions = dimensions;
        }

    }
}