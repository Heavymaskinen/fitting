using System;
using System.Collections.Generic;

namespace Fitting
{
    public class AidProgram
    {
        private IList<Feature> features;
        private string name;

        public AidProgram(string name, IList<Feature> features)
        {
            this.name = name;
            this.features = features;
        }

        public void AddFeature(Feature feature)
        {
            features.Add(feature);
        }
    }
}
