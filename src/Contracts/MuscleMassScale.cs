﻿using System.Collections.Generic;

namespace MiScaleBodyComposition.Contracts
{
    public struct MuscleMassScale
    {
        public IDictionary<Sex,double> Min { get; set; }
        public double[] Female { get; set; }
        public double[] Male { get; set; }
    }
}