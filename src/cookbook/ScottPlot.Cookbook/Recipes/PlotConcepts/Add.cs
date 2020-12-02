﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ScottPlot.Cookbook.Recipes.PlotConcepts
{
    class Add : IRecipe
    {
        public string ID => "plot_add";
        public string Title => "Manually Add a Plottable to the Plot";
        public string Description =>
            "You can create a plot manually, then add it to the plot with Add(). " +
            "This allows you to create custom plot types and add them to the plot.";

        public void ExecuteRecipe(Plot plt)
        {
            double[] xs = DataGen.Consecutive(51);
            double[] sin = DataGen.Sin(51);

            // instantiate a plottable
            var splt = new ScottPlot.Plottable.ScatterPlot(xs, sin);

            // customize its style or change its data as desired
            splt.color = Color.Navy;
            splt.markerSize = 10;
            splt.markerShape = MarkerShape.filledDiamond;

            // add it to the plot
            plt.Add(splt);
        }
    }
}