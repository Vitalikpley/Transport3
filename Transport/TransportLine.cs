namespace Transport.Models
{
    public class TransportLine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public static TransportLine TransportLine1 => new TransportLine { Id = 1, Name = "Маршрут №1", Type = "Автобус" };
        public static TransportLine TransportLine2 => new TransportLine { Id = 2, Name = "Маршрут №2", Type = "Автобус" };
        public static TransportLine TransportLine3 => new TransportLine { Id = 3, Name = "Маршрут №3", Type = "Автобус" };
        public static TransportLine TransportLine4 => new TransportLine { Id = 4, Name = "Маршрут №3", Type = "Тролейбус" };
        public static TransportLine TransportLine5 => new TransportLine { Id = 5, Name = "Маршрут №4", Type = "Тролейбус" };
        public static TransportLine TransportLine6 => new TransportLine { Id = 6, Name = "Маршрут №5", Type = "Тролейбус" };

        public static IEnumerable<TransportLine> DefaultTransportLine()
        {
            yield return TransportLine1;
            yield return TransportLine2;
            yield return TransportLine3;
            yield return TransportLine4;
            yield return TransportLine5;
            yield return TransportLine6;
        }

    }
}
