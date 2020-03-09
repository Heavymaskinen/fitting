namespace FittingV2.Formula
{
    public class Average : Rationale
    {
        public CompressorSettings CalculateSettings()
        {
            return new CompressorSettings {Attack = 10.0, Release = 20.0, Ratio = 0.2, Decay = 0.4, Sustain = 0.0};
        }
    }
}