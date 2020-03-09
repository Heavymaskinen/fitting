using System;
using System.Collections.Generic;

namespace Fitting
{
    public class ProgramFactory
    {
        public ProgramFactory()
        {
        }

        public AidProgram Create(IEnumerable<FeatureFactory> factories, HearingData hearingData)
        {
            var features = new List<Feature>();
            foreach (var factory in factories)
            {
                features.Add(factory.Create(hearingData));
            }

            return new AidProgram("Master", features);
        }
    }
}
