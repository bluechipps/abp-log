using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AB__Log_Viewer
{
    class Config
    {
        public static Config Inst;

        public bool showInfo;
        public bool showDebug;
        public bool showError;
        public string LogPath;
        public int frmWidth;
        public int frmHeight;
        public CustomFilter[] CustomFilters = new CustomFilter[0];


        public static void Load()
        {
            if (!File.Exists("config.json"))
            {
                Inst = new Config();
                Save();
            }

            Inst = JsonConvert.DeserializeObject<Config>(File.ReadAllText("config.json"));
        }

        public static void Save()
        {
            File.WriteAllText("config.json", JsonConvert.SerializeObject(Inst));
        }
    }
}
