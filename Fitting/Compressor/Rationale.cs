using System;
namespace Fitting
{
    public interface Rationale
    {
        CompressorSettings CreateSettings(HearingData data);
    }
}
