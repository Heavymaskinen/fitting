using System;
namespace Fitting
{
    public class SevereLossRationale :Rationale
    {
        public SevereLossRationale()
        {
        }

        public CompressorSettings CreateSettings(HearingData data)
        {
            return new CompressorSettings();
        }
    }
}
