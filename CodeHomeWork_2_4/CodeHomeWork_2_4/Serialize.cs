using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CodeHomeWork_2_4
{
    public static class Serialize
    {
        public static void Serialization()
        {
            string configFile = File.ReadAllText("config.json");
            Config json = JsonSerializer.Deserialize<Config>(configFile);
        }
    }
}
