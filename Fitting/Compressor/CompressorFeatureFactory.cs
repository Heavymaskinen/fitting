using System;
namespace Fitting
{
    public class CompressorFeatureFactory : FeatureFactory
    {
        public Rationale Rationale { get; set; }
        public Compressor Compressor { get; set; }

        public CompressorFeatureFactory(Rationale rationale, Compressor compressor)
        {
            Rationale = rationale;
            Compressor = compressor;
        }

        public Feature Create(HearingData data)
        {
            return new CompressorFeature(Compressor, Rationale.CreateSettings(data));
        }
    }
}
