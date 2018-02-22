using System;
using System.IO;
using CommandLine;
using Newtonsoft.Json;
using System.Linq;

namespace AddonUpdater
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<ProgramOptions>(args)
                .WithParsed(opts => {
                    Config config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(opts.ConfigFile));
                    Run(config, opts);                  
                })
                .WithNotParsed( errors => { System.Console.WriteLine(" ERROR "); });
        }

        private static void Run(Config config, ProgramOptions options)
        {
            GithubClient gc = new GithubClient();
            var response = gc.GetRepository(config.Addons.First());

        }
    }
}