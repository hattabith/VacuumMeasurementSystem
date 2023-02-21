
namespace VacuumLoggerVIT2.VacuumLogger.Application
{
    public class Parser : IParse
    {
        private string _parsedString;
        private string _name;
        private string _value;
        private string _type;
        public Parser()
        {
            _name = "DefaultName";
            _value = "DefaultValue";
            _type = "DefaultString";
        }
        public Parser(string name)
        {
            _name = name;
            _value = "DefaultValue";
            _type = "DefaultString";
        }
        public Parser(string name, string value)
        {
            _name = name;
            _value = value;
            _type = "DefaultString";
        }
        public Parser (string name, string value, string type)
        {
            _name = name;
            _value = value;
            _type = type;
            var ps = new ParsedStruct();
            ps.Name = _name;
            ps.Value = _value;
            ps.Type = _type;
        }
        public string ParsedString()
        {
            return _parsedString;
        }
        public struct ParsedStruct
        {
            public string Name;
            public string Value;
            public string Type;
        }
    }
}
