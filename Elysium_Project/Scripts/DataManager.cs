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
        public void init()
        {

        }
    }
    public class Planet
    {
        public int distance { get; set; }
        public int arcSpeed { get; set; }
        public string name;
        [JsonProperty]
        public string PlanetName { get; set; }
        public string PlanetType { get; set; }
        public int Sector_Num_Min { get; set; }
        public int Sector_Num_Max { get; set; }
        public List<Sector> sectors;
        public void init()
        {
            sectors = new List<Sector>();
            int num = Tools.Rnd.Next(Sector_Num_Min, Sector_Num_Max);
            for(int i = 0;i<num;i++)
            {
                Sector sec = Tools.instance().ReadJson<Sector>("SectorInfo.json", "Plains");
                sec.name = Tools.instance().GetRandomName(4, 8);
                sectors.Add(sec);
            }
        }
    }
    public class Star_System
    {
        public int x { get; set; }
        public int y { get; set; }
        public string name { get; set; }
        [JsonProperty]
        public string systemName { get; set; }
        public string systemType { get; set; }
        public int Planet_Num_Min { get; set; }
        public int Planet_Num_Max { get; set; }
        public string Star_Type { get; set; }
        public List<Planet> planets;
        public void init()
        {
            planets = new List<Planet>();
            int num = Tools.Rnd.Next(Planet_Num_Min, Planet_Num_Max);
            for(int i = 0;i<num;i++)
            {
                Planet pln = Tools.instance().ReadJson<Planet>("PlanetsInfo.json", "Ordinary System");
                pln.name = Tools.instance().GetRandomName(4, 8);
                planets.Add(pln);
            }
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
                //Star_System sys = Tools.instance().DeSerialize<Star_System>("StarSystemInfo.json");
                Star_System sys = Tools.instance().ReadJson<Star_System>("StarSystemInfo.json","Ordinary System");
                sys.name = Tools.instance().GetRandomName(4, 8);
                starSystems.Add(sys);
            }
        }
    }
    public class Civilization
    {

    }
}
