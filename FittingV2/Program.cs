using System;

namespace FittingV2
{
    public class Program
    {
        private CompressorFeature compressorFeature;

        public string Name { get; set; }

        public CompressorFeature CompressorFeature
        {
            get => compressorFeature;
            set => compressorFeature = value;
        }

        public Program(string name, CompressorFeature compressorFeature)
        {
            Name = name;
            this.compressorFeature = compressorFeature;
        }
    }
}