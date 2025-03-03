using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tessenger.Client.Custom.Algorithms
{
    public   interface IAlgorithms
    {
        public static string TempCacLocalImagePath = FileSystem.CacheDirectory + "/TempImage";
        public static string TempCacLocalAudioPath = FileSystem.CacheDirectory + "/TempAudio";

        public Dictionary<string, (string CountryName, string Language)> GetCountryes { get; }

       
        public void StatusBarCustomizetion(ContentPage contentPage, Color Light_color, Color Dark_color, bool isDark);

        bool IsColorLight(Color color);
    }
}
