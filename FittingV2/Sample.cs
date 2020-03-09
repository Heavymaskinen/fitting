using FittingV2.Compression;
using FittingV2.Formula;

namespace FittingV2
{
    public class Sample
    {
        public void Run()
        {
            var feature = new CompressorFeature(new PrimaryCompressor(), new Mild());

            var program = new Program("Master", feature);
            program.CompressorFeature.Settings.Attack = 20;
            program.CompressorFeature.ResetSettings();
            program.CompressorFeature = new CompressorFeature(new PrimaryCompressor(), new Severe());
            program.Name = "Master 2";

        }
    }
}