using System;
using CommandLine;

namespace AddonUpdater
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<ProgramOptions>(args)
                .WithParsed(opts => {
                    
                })
                .WithNotParsed( errors => { System.Console.WriteLine(" ERROR "); });
        }
    }
}
