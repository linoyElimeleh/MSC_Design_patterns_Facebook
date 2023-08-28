using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class AppSettings
    {
        public Point LastWindowsLocation { get; set; }

        public Size LastWindowsSize { get; set; }

        public bool RememberUser { get; set; }

        public string LastAccessToken { get; set; }

        public List<Entry> LastFriendList { get; set; }

        public AppSettings()
        {
            LastAccessToken = null;
            LastWindowsLocation = new Point(20, 50);
            LastWindowsSize = new Size(1000, 500);
            LastFriendList = null;
            RememberUser = false;
        }

        public void SaveToFile()
        {
            String strAppPath = Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            string path = Path.Combine(strAppPath, "Resources");

            if (!File.Exists($@"{path}\appSettings.xml"))
            {
                File.Create($@"{path}\appSettings.xml");
            }

            using (Stream stream = new FileStream($@"{path}\appSettings.xml", FileMode.Truncate))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
                stream.Close();
            }
        }

        public static T LoadFromFile<T>()
        {
            Object obj = null;

            String strAppPath = Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            string path = Path.Combine(strAppPath, "Resources");

            path = @".\Resources\";

            if (File.Exists($@"{path}\appSettings.xml") && File.ReadAllLines($@"{path}\appSettings.xml").Length != 0)
            {
                using (Stream stream = new FileStream($@"{path}\appSettings.xml", FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    obj = (T)serializer.Deserialize(stream);
                    stream.Close();

                }
            }

            return (T)obj;
        }

        private static string getPath()
        {
            string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            using (var stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(assemblyName + ".solutionpath.txt"))
            {
                using (var sr = new StreamReader(stream))
                {
                    return sr.ReadToEnd().Trim();
                }
            }
        }
    }

    public class Entry
    {
        public object Key;
        public object Value;

        public Entry()
        {
        }

        public Entry(object key, object value)
        {
            Key = key;
            Value = value;
        }
    }
}
