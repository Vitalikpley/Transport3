using Transport.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;
using TransportMigration;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using System.Security.Cryptography.X509Certificates;

using (var context = new TransportDbContext())
{

    //---------------------------------------------------------
    double findMax = context.Tickets.GroupBy(x => x.Price).Select(x => context.Tickets.Count(y => y.Price == x.Key)).Max();
    var f =context.Tickets.GroupBy(x => x.Price).Where(x => context.Tickets.Count(y => y.Price == x.Key) == findMax).Select(s => s.Key);
    Console.WriteLine($"Найбільш продаваємий квиток коштує {f.First().ToString()}$");


    //---------------------------------------------------------
    string marshrut = "Маршрут №2";
    string Stop = "Облдержадміністрація";
    var u = context.Schedules
        .Join(context.Lines, x => x.TransportLineId, y => y.Id, (x, y) => new {x.ArrivelTime, y.Type, NameOfLine = y.Name, StopId = x.StopStationId, })
        .Join(context.StopStations, x => x.StopId, y => y.Id, (x, y) => new { x.ArrivelTime, x.NameOfLine, x.Type, NameOfStop = y.Name})
        .Where(x => x.NameOfLine == marshrut && x.NameOfStop == Stop);
    foreach(var time in u)
        Console.WriteLine($"{time.Type} який має {marshrut} приїжає до зупинки {Stop} о {time.ArrivelTime}");

    //---------------------------------------------------------
    marshrut = "Маршрут №1";
    var e = context.Schedules
        .Join(context.Lines, x => x.TransportLineId, y => y.Id, (x, y) => new { y.Type, NameOfLine = y.Name, StopId = x.StopStationId, })
        .Join(context.StopStations, x => x.StopId, y => y.Id, (x, y) => new { x.NameOfLine, x.Type, NameOfStop = y.Name })
        .Where(x => x.NameOfLine == marshrut);
    Console.Write($"{e.First().Type} який має {marshrut} зупиняється на:");
    foreach (var time in e)
        Console.Write($" {time.NameOfStop}");
    Console.WriteLine();

    //---------------------------------------------------------
    var o = context.Tickets.Where(x => x.EndValid >  DateTime.Now);
    Console.Write($"Дійсні квитки:\n");
    foreach (var time in o)
        Console.WriteLine($"Індефікатор: {time.Id}, ціна: {time.Price}, закінчення: {time.EndValid.ToString()}");


    //---------------------------------------------------------
    string Stop1 = "Майдан Київський";
    string Stop2 = "Облдержадміністрація";
    var st12 = context.Schedules
    .Join(context.Lines, x => x.TransportLineId, y => y.Id, (x, y) => new { y.Type, y.Id, StopId = x.StopStationId })
    .Join(context.StopStations, x => x.StopId, y => y.Id, (x, y) => new { x.Id, x.Type, NameOfStop = y.Name })
    .Where(s => s.NameOfStop == Stop1 || s.NameOfStop == Stop2)
    .ToList() 
    .GroupBy(s => s.Id)
    .Where(g => g.Count() >= 2)
    .Select(g => g.First().Id) 
    .ToList();

    Console.Write($"Транспорт який проїжає від '{Stop1}' до '{Stop2}':");
    foreach (var time in st12)
        Console.Write($" №{time}");
    Console.WriteLine();

}