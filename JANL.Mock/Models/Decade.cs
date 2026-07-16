using System;
using System.Collections.Generic;

namespace JANL.Models
{
    public class Decade
    {
        public Decade(string _name, DateTime _date)
        {
            Name = _name;
            Date = _date;
        }

        public DateTime Date { get; set; }
        public string Name { get; set; }

        public static List<Decade> GetDecades()
        {
            var list = new List<Decade>
            {
                new Decade("Нулевые",new DateTime(2000, 1, 1)),
                new Decade("Десятые",new DateTime(2010, 1, 1)),
                new Decade("Двадцатые",new DateTime(2020, 1, 1))
            };
            return list;
        }

        public override string ToString()
        {
            return $"{Name} - {Date}";
        }
    }
}