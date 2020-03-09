namespace FittingV2.Formula
{
    public class Mild : Rationale
    {
        public CompressorSettings CalculateSettings()
        {
            return new CompressorSettings {Attack = 5.0, Release = 5.0, Ratio = 0.02, Decay = 1.4, Sustain = 1.0};
        }
    }
}