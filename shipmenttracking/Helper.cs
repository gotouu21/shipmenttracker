using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace shipmenttracking
{
    public class Helper
    {
        internal static List<oneItem> shipItem;
        string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        string datapath = Path.Combine(path, "data.xml");

        public void mockItems()
        {

        }

        public void getItems()
        {
            shipItem = new List<oneItem>();
            var streamReader = new StreamReader(path);
            shipItem = File.ReadAllLines(path).ToList();
            StreamReader.close();

            return;
        }
        public void saveItems()
        {
            StreamWriter stream = File.CreateText(path);
            for(int i=0;i<shipItem.Count; i++)
            {
                stream.Write(i.ToString(), " ", shipItem[i].ToString());
            }
            stream.Close();
            return;
        }
        public void addItem()
        {

        }
    }
}