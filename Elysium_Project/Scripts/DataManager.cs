using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

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
        public int x;
        public int y;
        public string name;
        public Sector()
        {

        }
    }
    public class Planet
    {
        public int distance;
        public int arcSpeed;
        public string name;
        public List<Sector> sectors;
        public Planet()
        {
            sectors = new List<Sector>();
        }
    }
    public class Star_System
    {
        public int x;
        public int y;
        public string name;
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
                Star_System sys = new Star_System();
                sys.name = Tools.instance().GetRandomName(4, 8);
                starSystems.Add(sys);
            }
        }
    }
    public class Civilization
    {

    }
}
