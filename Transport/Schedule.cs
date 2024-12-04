using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public TransportLine? Line { get; set; }
        public int TransportLineId { get; set; }
        public StopStation? StopStation { get; set; }
        public int StopStationId { get; set; }
        public TimeOnly ArrivelTime { get; set; }

        public static Schedule StopStation1 => new Schedule { Id = 1, TransportLineId = TransportLine.TransportLine2.Id, StopStationId = StopStation.StopStation4.Id, ArrivelTime = new TimeOnly(15, 15)};
        public static Schedule StopStation2 => new Schedule { Id = 2, TransportLineId = TransportLine.TransportLine1.Id, StopStationId = StopStation.StopStation3.Id, ArrivelTime = new TimeOnly(16, 23)};
        public static Schedule StopStation3 => new Schedule { Id = 3, TransportLineId = TransportLine.TransportLine2.Id, StopStationId = StopStation.StopStation3.Id, ArrivelTime = new TimeOnly(18, 10)};
        public static Schedule StopStation4 => new Schedule { Id = 4, TransportLineId = TransportLine.TransportLine3.Id, StopStationId = StopStation.StopStation1.Id, ArrivelTime = new TimeOnly(8, 5)};
        public static Schedule StopStation5 => new Schedule { Id = 5, TransportLineId = TransportLine.TransportLine6.Id, StopStationId = StopStation.StopStation6.Id, ArrivelTime = new TimeOnly(10, 56)};
        public static Schedule StopStation6 => new Schedule { Id = 6, TransportLineId = TransportLine.TransportLine5.Id, StopStationId = StopStation.StopStation5.Id, ArrivelTime = new TimeOnly(12, 54)};


        public static IEnumerable<Schedule> DefaultSchedule()
        {
            yield return StopStation1;
            yield return StopStation2;
            yield return StopStation3;
            yield return StopStation4;
            yield return StopStation5;
            yield return StopStation6;
        }
    }
}
