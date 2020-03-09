namespace FittingV2.Formula
{
    public class Severe : Rationale
    {
        public CompressorSettings CalculateSettings()
        {
            return new CompressorSettings {Attack = 20.0, Release = 40.0, Ratio = 0.1, Decay = 0.04, Sustain = 0.0};
        }
    }
}