using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace KNA
{
    public class LDBbuilder
    {
        public void newDIR(string name, string path)
        {
            if (path == "CurrentDir")
            {
                Directory.CreateDirectory(Environment.CurrentDirectory + @"\" + name);
            }
            else
            {
                Directory.CreateDirectory(path + @"\" + name);
            }
        }
        public void CreateNewSubDIR(string name, string path)
        {
            if (path == "CurrentDir")
            {
                Directory.CreateDirectory(Environment.CurrentDirectory + @"\" + name);
            }
            else
            {
                Directory.CreateDirectory(path + @"\" + name);
            }
        }

        public void addNewValueToDIR(string valueName, string path, string value)
        {
            if (path == "CurrentDir")
            {
                File.WriteAllText(Environment.CurrentDirectory + @"\" + valueName, value);
            }
            else
            {
                File.WriteAllText(path + @"\" + valueName, value);
            }
        } 
    }
    
}
