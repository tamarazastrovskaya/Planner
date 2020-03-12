using Microsoft.Extensions.Configuration.Ini;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Services
{
    class Settings
    {
        private static IniConfigurationProvider instanceSettings;
        public static IniConfigurationProvider InstanceSettings { get => instanceSettings; }

        static Settings()
        {
            instanceSettings = SettingsLoader.LoadSettings();
        }
    }
}
