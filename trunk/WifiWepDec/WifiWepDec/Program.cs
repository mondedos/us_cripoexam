using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.IO;

namespace WifiWepDec
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] BSSID = args[0].Split(':');
                string[] essid = args[1].Split('_');

                StringBuilder k = new StringBuilder();
                bool noesprimero = false;
                for (int i = 0; i < 3; i++)
                {
                    if (noesprimero)
                    {
                        k.Append(":");
                    }
                    k.Append(BSSID[i]);
                    noesprimero = true;
                }

                string initkey = ConfigurationManager.AppSettings[k.ToString()];

                StreamWriter swWriter = File.AppendText(args[2]);

                for (int i = 0; i < 65536; i++)
                {
                    StringBuilder sb = new StringBuilder(initkey);
                    sb.Append(string.Format("{0:X4}", i));
                    sb.Append(essid[1]);

                    swWriter.WriteLine(sb.ToString());
                }

                swWriter.Close(); 
            }
            catch (Exception)
            {

                Console.WriteLine("Uso:");
                Console.WriteLine(string.Format("WifiWepDec.exe <bssid> <essid> <ficherosalida>"));
            }
        }
    }
}
