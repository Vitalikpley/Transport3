using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport.Models
{
    public class StopStation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public static StopStation StopStation1 => new StopStation { Id = 1, Name = "Вул. Івана Франка", Location = "Вул. Івана Франка 1" };
        public static StopStation StopStation2 => new StopStation { Id = 2, Name = "Майдан Київський", Location = "Вул. Дубнівсяка 2" };
        public static StopStation StopStation3 => new StopStation { Id = 3, Name = "Облдержадміністрація", Location = "Проспект Волі 1" };
        public static StopStation StopStation4 => new StopStation { Id = 4, Name = "Технікум", Location = "Проспект Волі 2" };
        public static StopStation StopStation5 => new StopStation { Id = 5, Name = "Поліклініка №1", Location = "Проспект Волі 3" };
        public static StopStation StopStation6 => new StopStation { Id = 6, Name = "Стоматполіклініка", Location = "Проспект Волі 4" };

        public static IEnumerable<StopStation> DefaultStopStation()
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
