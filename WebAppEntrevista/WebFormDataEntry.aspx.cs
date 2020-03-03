using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAPI;

namespace WebAppEntrevista
{
    public partial class WebFormDataEntry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            CubeService wservice = new CubeService();

            Position wpositionCubeA = wservice.setCubePosition(Double.Parse(txtCoordXCubeA.Text), Double.Parse(txtCoordYCubeA.Text), Double.Parse(txtCoordZCubeA.Text));
            CubeDimensions wdimensionCubeA = wservice.setCubeDimensions(Double.Parse(txtHeightCubeA.Text), Double.Parse(txtLengthCubeA.Text), Double.Parse(txtWidthCubeA.Text));
            Cube wcubeA = new Cube(wpositionCubeA, wdimensionCubeA);

            Position wpositionCubeB = wservice.setCubePosition(Double.Parse(txtCoordXCubeB.Text), Double.Parse(txtCoordYCubeB.Text), Double.Parse(txtCoordZCubeB.Text));
            CubeDimensions wdimensionCubeB = wservice.setCubeDimensions(Double.Parse(txtHeightCubeB.Text), Double.Parse(txtLengthCubeB.Text), Double.Parse(txtWidthCubeB.Text));
            Cube wcubeB = new Cube(wpositionCubeB, wdimensionCubeB);

       }
    }
}