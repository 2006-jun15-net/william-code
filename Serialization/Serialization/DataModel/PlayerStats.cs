using System;
using System.Collections.Generic;
using System.Text;

namespace Serialization.DataModel
{
    class PlayerStats
    {
        public string Name { get; set; }
        public double FreeThrowPercentage { get; set; }
        public double PointsPerGame { get; set; }
        public Dictionary<int, double> ArcLocations { get; set; }

        // POCO - Plain Old 
    }
}
