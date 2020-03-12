using Force.DeepCloner;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Ini;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Services
{
    class SettingsLoader
    {
        public static IniConfigurationProvider LoadSettings()
        {
            IniConfigurationSource source = new IniConfigurationSource();
            source.Path = "Settings.ini";
            IniConfigurationProvider settings = (IniConfigurationProvider)source.Build(new ConfigurationBuilder());
            settings.Load();
            return settings;
        }
    }
}
