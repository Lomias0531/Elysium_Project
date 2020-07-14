using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elysium_Project.Scripts
{
    class DataManager:Singletion<DataManager>
    {
        public Config config;
        public Galaxy_Map galaxy;
        public Civilization civ;
    }
    public class Config
    {

    }
    public class Sector
    {
        public int x { get; set; }
        public int y { get; set; }
        public string name { get; set; }
        public Sector()
        {

        }
    }
    public class Planet
    {
        public int distance { get; set; }
        public int arcSpeed { get; set; }
        public string name;
        public List<Sector> sectors;
        public Planet()
        {
            sectors = new List<Sector>();
        }
    }
    public class Star_System
    {
        public int x { get; set; }
        public int y { get; set; }
        public string name { get; set; }
        [JsonProperty]
        public string systemType { get; set; }
        public string systemType2 { get; set; }
        public int Planet_Num_Min { get; set; }
        public int Planet_Num_Max { get; set; }
        public string Star_Type;
        public List<Planet> planets;
        public Star_System()
        {
            planets = new List<Planet>();
        }
    }
    public class Galaxy_Map
    {
        public List<Star_System> starSystems;
        public Galaxy_Map()
        {
            starSystems = new List<Star_System>();
            int systemNum = new Random().Next(30, 40);
            for(int i = 0;i<systemNum;i++)
            {
                Star_System sys = Tools.instance().DeSerialize<Star_System>(Tools.instance().Get_Json_Path("StarSystemInfo.json"));
                sys.name = Tools.instance().GetRandomName(4, 8);
                starSystems.Add(sys);
            }
        }
    }
    public class Civilization
    {

    }
}
