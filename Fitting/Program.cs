using System;

namespace Fitting
{
    class Program
    {
        static void Main(string[] args)
        {
            var usecase = new CreateProgramUsecase();

            usecase.AddFeature(new CompressorFeatureFactory(new SevereLossRationale(), new PrimaryCompressor()));
            var program = usecase.CreateProgram(new HearingData());
        }
    }
}
