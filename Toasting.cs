using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace Toaster
{
    public class Toasting
    {
        public void AddPluginName(string pluginName) => Name = pluginName;
        public void AddPluginAuthor(string pluginAuthor) => Author = pluginAuthor;
        public void AddPluginVersion(string pluginVersion) => Version = pluginVersion;
        public void AddPluginComments(string pluginComments) => Comments = pluginComments;
        
        public Toasting() { }

        public string Name;
        public string Author;
        public string Version;
        public string Comments;

        public void Load()
        {
            if (Name != null)
                Name = Assembly.GetCallingAssembly().GetName().Name;

            PluginData loadedData = new PluginData
            {
                PluginName = Name,
                PluginAuthor = Author,
                PluginVersion = Version,
                AdditionalComments = Comments
            };

            string jsonData = JsonSerializer.Serialize<PluginData>(loadedData);
            using (StreamWriter sw = new StreamWriter(Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), "Plugins"), $"{Name}.json")))
            {
                sw.WriteLine(jsonData);
                sw.Close();
            }

        }
 
    }
}
