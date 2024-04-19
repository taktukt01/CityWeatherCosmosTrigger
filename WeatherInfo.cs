using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityWeatherSender
{
    public class WeatherInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public LocalNames Local_Names { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
    }

    public class LocalNames
    {
        public string Tt { get; set; }
        public string El { get; set; }
        public string Fr { get; set; }
        public string Ko { get; set; }
        public string En { get; set; }
        public string Gl { get; set; }
        public string De { get; set; }
        public string Vi { get; set; }
        public string Sr { get; set; }
        public string Uk { get; set; }
        public string Pl { get; set; }
        public string Zh { get; set; }
        public string Eo { get; set; }
        public string Ca { get; set; }
        public string Pa { get; set; }
        public string Te { get; set; }
        public string It { get; set; }
        public string He { get; set; }
        public string Hr { get; set; }
        public string Bn { get; set; }
        public string Is { get; set; }
        public string Hi { get; set; }
        public string Ar { get; set; }
        public string Fa { get; set; }
        public string Br { get; set; }
        public string Be { get; set; }
        public string Cy { get; set; }
        public string Ja { get; set; }
        public string Kn { get; set; }
        public string Es { get; set; }
        public string Oc { get; set; }
        public string Ga { get; set; }
        public string Cs { get; set; }
        public string Ur { get; set; }
        public string Pt { get; set; }
        public string Ru { get; set; }
    }

}
