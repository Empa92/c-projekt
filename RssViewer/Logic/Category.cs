﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Security.AccessControl;

namespace Logic
{
    public class Category
    {
        List<Category> categoryList = new List<Category>();

        public void AddNewCategory(string categoryname)
        {
            string path = Directory.GetCurrentDirectory() + @"\" + categoryname;
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");

            XmlWriter writeXml = XmlWriter.Create(path, settings);

            writeXml.WriteStartDocument();
            writeXml.WriteStartElement("channel");

            writeXml.WriteEndDocument();
            writeXml.Close();


        }


        public bool NewFolder(string categoryname)
        {
            DirectorySecurity securityRules = new DirectorySecurity();
            securityRules.AddAccessRule(new FileSystemAccessRule("Users", FileSystemRights.FullControl, AccessControlType.Allow));
            
            Directory.CreateDirectory(categoryname);
            return true;
        }

    }
}