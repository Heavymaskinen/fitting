using System;
using System.Collections.Generic;

namespace Fitting
{
    public class CreateProgramUsecase
    {
        private IList<FeatureFactory> factories;
        private ProgramFactory factory;

        public CreateProgramUsecase()
        {
            factories = new List<FeatureFactory>();
            factory = new ProgramFactory();
        }

        public void AddFeature(FeatureFactory factory)
        {
            factories.Add(factory);
        }

        public AidProgram CreateProgram(HearingData data)
        {
            return factory.Create(factories, data);
        }
    }
}
