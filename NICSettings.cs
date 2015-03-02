using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace IPSettingsTool
{
    public class NICSettings
    {
        #region variables

        public string Name = string.Empty;

        public string IP = string.Empty;
        public string Subnet = string.Empty;
        public string Gateway = string.Empty;
        public string DNS = string.Empty;

        #endregion

        #region Constructors

        public NICSettings() { }

        public NICSettings(string name)
        {
            Name = name;
        }

        #endregion

        #region public methods

        //checks if the IP address and Subnet mask are correct 
        public bool isValidIP(string IP)
        {
            if (0 == IP.Length)
            {
                MessageBox.Show("No IP specified", "End");
                return false;
            }
            
            for (int i = 0; i < IP.Length; i++)
            {
                string[] segments = IP.Split('.');
                
                if (segments.Length != 4)
                {
                    MessageBox.Show("Invalid format found! Valid format is XXX.XXX.XXX.XXX", "End");
                    return false;

                }

                foreach (string segment in segments)
                {
                    try
                    {
                        byte value = byte.Parse(segment);
                    }
                    catch
                    {
                        MessageBox.Show("Only values from 0 to 255 allowed", "End");
                        return false;
                                                
                    }

                }

                
            }
            return true;
        }

        #endregion

    }
}