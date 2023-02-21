
namespace VacuumLoggerVIT2.VacuumLogger.Application
{
    internal interface IParse
    {
        public string ParsedString();
        public struct ParsedStruct
        {
            public string Name;
            public string Value;
            public string Type; 
        }
    }
}
