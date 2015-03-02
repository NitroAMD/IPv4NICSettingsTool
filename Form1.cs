using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IPSettingsTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // get the NIC names
            ArrayList nicNames = WMIHelper.GetNICNames();
            
            // populate the NIC list
            cboNIC.Items.Clear();
            foreach (string name in nicNames)
            {
                cboNIC.Items.Add(name);
            }
                
            // if a NIC is found, select the first one
            if (cboNIC.Items.Count > 0)
            {
                cboNIC.SelectedIndex = 0;
                grpNIC.Enabled = true;
            }

        }

        private string _NICName
        {
            get
            {
                return cboNIC.SelectedItem as string;
            }
        }


        private void loadCurrentSetting(string nicName)
        {

            string[] ipAddresses;
            string[] subnets;
            string[] gateways;
            string[] dnses;

            // Load current IP configuration for the selected NIC
            WMIHelper.GetIP(nicName, out ipAddresses, out subnets, out gateways, out dnses);

            // if network connection is disabled, no information will be available
            if (null == ipAddresses || null == subnets || null == gateways || null == dnses)
            {
                txtIP.Text = null;
                txtSubnet.Text = null;
                txtGateway.Text = null;
                txtDNS.Text = null;
                return;
            }
                

            // Show the setting
            txtIP.Text = ipAddresses[0];
            txtSubnet.Text = subnets[0];
            txtGateway.Text = string.Join(",", gateways);
            txtDNS.Text = string.Join(",", dnses);
        }


        private void cboNIC_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCurrentSetting(_NICName);
        }

        private void btnSET_Click(object sender, EventArgs e)
        {
            

            NICSettings checker = new NICSettings();

            //checks and validates the prerequirements to set the new values
            if (checker.isValidIP(txtIP.Text) && checker.isValidIP(txtSubnet.Text) && checker.isValidIP(txtGateway.Text) && checker.isValidIP(txtDNS.Text))
            {
                WMIHelper.SetIP(_NICName, txtIP.Text, txtSubnet.Text, txtGateway.Text, txtDNS.Text);
                MessageBox.Show("DONE","End");

            }

            else
            {
                MessageBox.Show("NOTHING Set");
            }
            
        }

        //checks if the provided CIDR number is convertable and converts it to a full subnet pattern if possible
        private void btnCIDR_Click(object sender, EventArgs e)
        {
            string CIDR = txtSubnet.Text;

            switch (CIDR)
            {
                case "0":
                    txtSubnet.Text = "0.0.0.0";
                    break;
                case "1":
                    txtSubnet.Text = "128.0.0.0";
                    break;
                case "2":
                    txtSubnet.Text = "192.0.0.0";
                    break;
                case "3":
                    txtSubnet.Text = "224.0.0.0";
                    break;
                case "4":
                    txtSubnet.Text = "240.0.0.0";
                    break;
                case "5":
                    txtSubnet.Text = "248.0.0.0";
                    break;
                case "6":
                    txtSubnet.Text = "252.0.0.0";
                    break;
                case "7":
                    txtSubnet.Text = "254.0.0.0";
                    break;
                case "8":
                    txtSubnet.Text = "255.0.0.0";
                    break;
                case "9":
                    txtSubnet.Text = "255.128.0.0";
                    break;
                case "10":
                    txtSubnet.Text = "255.192.0.0";
                    break;
                case "11":
                    txtSubnet.Text = "255.224.0.0";
                    break;
                case "12":
                    txtSubnet.Text = "255.240.0.0";
                    break;
                case "13":
                    txtSubnet.Text = "255.248.0.0";
                    break;
                case "14":
                    txtSubnet.Text = "255.252.0.0";
                    break;
                case "15":
                    txtSubnet.Text = "255.254.0.0";
                    break;
                case "16":
                    txtSubnet.Text = "255.255.0.0 ";
                    break;
                case "17":
                    txtSubnet.Text = "255.255.128.0";
                    break;
                case "18":
                    txtSubnet.Text = "255.255.192.0";
                    break;
                case "19":
                    txtSubnet.Text = "255.255.224.0";
                    break;
                case "20":
                    txtSubnet.Text = "255.255.240.0";
                    break;
                case "21":
                    txtSubnet.Text = "255.255.248.0";
                    break;
                case "22":
                    txtSubnet.Text = "255.255.252.0";
                    break;
                case "23":
                    txtSubnet.Text = "255.255.254.0";
                    break;
                case "24":
                    txtSubnet.Text = "255.255.255.0";
                    break;
                case "25":
                    txtSubnet.Text = "255.255.255.128";
                    break;
                case "26":
                    txtSubnet.Text = "255.255.255.192";
                    break;
                case "27":
                    txtSubnet.Text = "255.255.255.224";
                    break;
                case "28":
                    txtSubnet.Text = "255.255.255.240";
                    break;
                case "29":
                    txtSubnet.Text = "255.255.255.248";
                    break;
                case "30":
                    txtSubnet.Text = "255.255.255.252";
                    break;

                default:

                    break;
            }

        }
                              
    }
}
