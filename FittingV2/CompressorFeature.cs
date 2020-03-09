namespace FittingV2
{
    public class CompressorFeature
    {
        private CompressorSettings settings;
        private Rationale rationale;
        private Compressor compressor;

        public CompressorSettings Settings => settings;

        public CompressorFeature(Compressor compressor, Rationale rationale)
        {
            this.compressor = compressor;
            this.rationale = rationale;
            ResetSettings();
        }

        public void ResetSettings()
        {
            settings = rationale.CalculateSettings();
        }
    }
}