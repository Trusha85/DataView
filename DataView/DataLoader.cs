using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace DataView
{
    internal class DataLoader
    {
        public static DataTable LoadContacts(string path)
        {
            var dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Starred");

            foreach (string line in File.ReadAllLines(path))
            {
                string name = GetValue(line, "name");
                string phone = GetValue(line, "number");
                string starred = GetValue(line, "starred");

                dt.Rows.Add(name, phone, starred);
            }

            return dt;
        }

        private static string GetValue(string line, string key)
        {
            string pattern = $@"\b{key}=([^\s]*)";
            var match = Regex.Match(line, pattern);
            return match.Success ? match.Groups[1].Value : "N/A";
        }

        public static DataTable LoadSMS(string path)
        {
            var dt = new DataTable();
            dt.Columns.Add("Date");
            dt.Columns.Add("Sender");
            dt.Columns.Add("Message");

            foreach (string line in File.ReadAllLines(path))
            {
                string date = GetValue(line, "date");
                string sender = GetValue(line, "address");
                string message = GetValue(line, "body");

                dt.Rows.Add(date, sender, message);
            }

            return dt;
        }

        public static DataTable LoadCalls(string path)
        {
            var dt = new DataTable();
            dt.Columns.Add("Date");
            dt.Columns.Add("Number");
            dt.Columns.Add("Duration");
            dt.Columns.Add("Type");

            foreach (string line in File.ReadAllLines(path))
            {
                string date = GetValue(line, "date");
                string number = GetValue(line, "number");
                string duration = GetValue(line, "duration");
                string type = GetValue(line, "type");

                dt.Rows.Add(date, number, duration, type);
            }

            return dt;
        }

        public static DataTable LoadDeviceInfo(string cpuPath, string memPath)
        {
            var dt = new DataTable();
            dt.Columns.Add("Type");
            dt.Columns.Add("Info");

            dt.Rows.Add("CPU", File.ReadAllText(cpuPath));
            dt.Rows.Add("Memory", File.ReadAllText(memPath));

            return dt;
        }
    }
}
