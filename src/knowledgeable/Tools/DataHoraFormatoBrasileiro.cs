using System;

namespace knowledgeable.Tools
{
    public static class DataHoraFormatoBrasileiro
    {
        public static DateTime RetornaDataAtual()
        {
            var dataHoraUtc = DateTime.UtcNow;
            var horárioDeBrasília = TimeZoneInfo.FindSystemTimeZoneById("Brazil/East");
            return TimeZoneInfo.ConvertTimeFromUtc(dataHoraUtc, horárioDeBrasília);
        }
    }
}
