using System;
namespace Fitting
{
    public class CompressorFeature : Feature
    {
        private Compressor compressor;
        private CompressorSettings settings;

        public CompressorFeature(Compressor compressor, CompressorSettings settings)
        {
            this.compressor = compressor;
            this.settings = settings;
        }
    }
}
