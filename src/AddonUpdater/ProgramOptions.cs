using System;
using CommandLine;

namespace AddonUpdater
{
    class ProgramOptions
    {
        [Option('f', "file", Required = true, HelpText = "Input files to be processed")]
        public string ConfigFile { get; set; }       
    }
}
