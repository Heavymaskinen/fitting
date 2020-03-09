
using System;
namespace Fitting
{
    public interface FeatureFactory
    {
        Feature Create(HearingData data);
    }
}
