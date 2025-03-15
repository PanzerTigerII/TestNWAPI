using System.Collections.Generic;
namespace PanzerCustomRoles_NWAPI.Configs
{
    public class MainConfig
    {
        public string StringValue { get; set; } = "Test";
        public int IntValue { get; set; } = 100;

        public Dictionary<string, string> DictionaryValue { get; set; } = new Dictionary<string, string>()
        {
            { "Value1", "Param1" },
            { "Value2", "Param2" },
        };
    }
}