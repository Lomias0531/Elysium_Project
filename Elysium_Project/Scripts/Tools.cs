using System;
using System.IO;
using Newtonsoft.Json;
using LitJson;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elysium_Project.Scripts
{
    class Tools:Singletion<Tools>
    {
        public readonly string JsonPath = Application.ExecutablePath;
        readonly Random Rnd = new Random();
        #region 字母表
        private enum Chart
        {
            A, E, I, O, U
        }
        private enum Chart_0
        {
            B, C, D, F, G, H, J, K, L, M, N, P, Q, R, S, T, V, W, X, Y, Z
        }
        private enum Chart_1
        {
            a, e, i, o, u
        }
        private enum Chart_2
        {
            b, c, d, f, g, h, j, k, l, m, n, p, q, r, s, t, v, w, x, y, z
        }
        #endregion
        public string GetRandomName(int min_length,int max_length)
        {
            int Length = Rnd.Next(min_length, max_length);
            string Name = "";
            bool Last = false;
            int Pop = 0;
            switch (Rnd.Next(0, 2))
            {
                case 0:
                    {
                        Chart[] chart = Enum.GetValues(typeof(Chart)) as Chart[];
                        Name += chart[Rnd.Next(0, chart.Length)].ToString();
                        Last = true;
                        Pop = +15;
                        break;
                    }
                case 1:
                    {
                        Chart_0[] chart = Enum.GetValues(typeof(Chart_0)) as Chart_0[];
                        Name += chart[Rnd.Next(0, chart.Length)].ToString();
                        Last = false;
                        Pop = 0;
                        break;
                    }
            }
            while (Name.Length < Length)
            {
                switch (Last)
                {
                    case true:
                        {
                            if (Rnd.Next(0, 100) < 30 - Pop)
                            {
                                Chart_1[] chart = Enum.GetValues(typeof(Chart_1)) as Chart_1[];
                                Name += chart[Rnd.Next(0, chart.Length)].ToString();
                                Last = true;
                                Pop += 15;
                            }
                            else
                            {
                                Chart_2[] chart = Enum.GetValues(typeof(Chart_2)) as Chart_2[];
                                Name += chart[Rnd.Next(0, chart.Length)].ToString();
                                Last = false;
                                Pop = 0;
                            }
                            break;
                        }
                    case false:
                        {
                            Chart_1[] chart = Enum.GetValues(typeof(Chart_1)) as Chart_1[];
                            Name += chart[Rnd.Next(0, chart.Length)].ToString();
                            Last = true;
                            Pop += 15;
                            break;
                        }
                }
            }
            return Name;
        }
        public void Serialize<T>(T obj,string filepath,string filename)
        {
            string json = JsonConvert.SerializeObject(obj);
            if (!Directory.Exists(filepath))
            {
                Directory.CreateDirectory(filepath);
            }
            File.WriteAllText(filepath + filename, json);
        }
        public T DeSerialize<T>(string filename)
        {
            T obj = default(T);
            if (File.Exists(filename))
            {
                string json = File.ReadAllText(filename);
                obj = (T)JsonConvert.DeserializeObject(json, typeof(T));
            }

            return obj;
        }
        private string Get_Json_Path(string filename)
        {
            string path;
            path = Application.ExecutablePath.Replace("bin\\Debug\\", "");
            path = path.Replace("Elysium_Project.exe", "");
            path += "Resources\\Json\\" + filename;
            return path;
        }
        private string Get_Save_Path(string filename)
        {
            string path;
            path = Application.ExecutablePath.Replace("bin\\Debug\\", "");
            path = path.Replace("Elysium_Project.exe", "");
            path += "Save\\" + filename;
            return path;
        }
        public T ReadJson<T>(string filename)
        {
            T obj = System.Activator.CreateInstance<T>();
            Type t = typeof(T);
            string _file = Get_Json_Path(filename);
            if(File.Exists(_file))
            {
                StreamReader SR = new StreamReader(Get_Json_Path(filename));
                string JR = SR.ReadToEnd();
                SR.Close();
                switch (t.Name)
                {
                    case "Star_System":
                        {
                            obj = JsonMapper.ToObject<T>(JR);
                            break;
                        }
                }
            }
            return obj;
        }
    }
}