using System;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using My;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

namespace My
{
    public class Class1
    {
        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
        public string CheckPrevMac(string str)
        {
            string previous = str;
            return previous;
        }

        public string[] GetMacAddress()
        {
            const int MIN_MAC_ADDR_LENGTH = 12;
            string macAddress = string.Empty;
            long maxSpeed = -1;
            string[] macs = new string[10];
            int il = 1;

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.GetPhysicalAddress() != null)
                {
                    var s = nic.GetPhysicalAddress().ToString();
                    var list = Enumerable
                        .Range(0, s.Length / 2)
                        .Select(i => s.Substring(i * 2, 2))
                        .ToList();
                    var res = string.Join("-", list);
                    if (res != "")
                    {
                        if (il <= 10)
                        {
                            macs[il] = res;
                            il++;
                        }
                    }

                    string tempMac = nic.GetPhysicalAddress().ToString();
                    if (nic.Speed > maxSpeed &&
                        !string.IsNullOrEmpty(tempMac) &&
                        tempMac.Length >= MIN_MAC_ADDR_LENGTH)
                    {
                        maxSpeed = nic.Speed;
                        macAddress = tempMac;
                    }
                }
            }

            return macs;
        }

        public string[] thonk()
        {
            string[] dummy = new string[10];
            foreach (string s in Registry.CurrentUser.GetSubKeyNames())
            {
                RegistryKey rk = Registry.CurrentUser.OpenSubKey(s);
                string Key = rk.ToString();
                string Key2 = Key.Replace("HKEY_CURRENT_USER\\", "");
                bool Check = IsDigitsOnly(Key2);
                if (Check) {
                    RegistryKey ecks = Registry.CurrentUser.OpenSubKey(Key2);
                    {
                        string ecks2 = ecks.ToString();
                        string ecksxd = ecks2.Replace("HKEY_CURRENT_USER\\", "");
                        string[] hello = GetRegistry(ecksxd);
                        return hello;
                    }
                }
            }
            return dummy;
        }

    /*    public string[] thonk2()
        {
            string[] dummy = new string[10];
            foreach (string s in Registry.CurrentUser.OpenSubKey(@"Software\\Microsoft").GetSubKeyNames())
            {
                RegistryKey rk = Registry.CurrentUser.OpenSubKey(@"Software\\Microsoft" + "\\" + s);
                string Key = rk.ToString();
                string Key2 = Key.Replace("HKEY_CURRENT_USER\\Software\\Microsoft\\", "");
                bool Check = IsDigitsOnly(Key2);
                if (Check)
                {
                    RegistryKey ecks = Registry.CurrentUser.OpenSubKey(@"Software\\Microsoft" + "\\" + s);
                    {
                        string ecks2 = ecks.ToString();
                        string ecksxd = ecks2.Replace("HKEY_CURRENT_USER\\Software\\Microsoft\\", "");
                        string[] hey = new string[2];
                        return GetRegistry2(ecksxd);
                    }
                }
            }
            return dummy;
        }


        public string[] GetRegistry2(string str)
        {
            string registryValue = string.Empty;
            string[] hkcu = new string[15];
            hkcu[0] = str;
            int il = 1;
            try
            {
                //  RegistryKey MyReg = Registry.CurrentUser.OpenSubKey(str);
                //  Console.WriteLine(str + "\\");
                // var subKeys = MyReg.GetSubKeyNames();
                //  Console.WriteLine(subKeys);
                //  foreach (string str2 in subKeys)
                //  {
                //      Console.WriteLine(str2);
                //  }
                RegistryKey OurKey = Registry.CurrentUser;
                OurKey = OurKey.OpenSubKey(@"Software\\Microsoft" + "\\" + str, true);
                foreach (string Keyname in OurKey.GetValueNames())
                {
                    try
                    {
                        using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\\Microsoft" + "\\" + str))
                        {
                            if (key != null)
                            {
                                try
                                {
                                    var value = (byte[])key.GetValue(Keyname);
                                    var valueAsString = BitConverter.ToString(value);
                                    if (il <= 10)
                                    {
                                        string res = valueAsString.Replace(@"-", @",");
                                        hkcu[il] = Keyname;
                                        il++;
                                        hkcu[il] = res.ToLower();
                                        il++;
                                    }
                                }
                                catch (Exception ex) { }
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
            catch (Exception ex)
            {

            }
            return hkcu;
        } */

        public static string[] GetRegistry(string str)
        {
            string registryValue = string.Empty;
            string[] Reg1 = new string[15];
            Reg1[0] = str;
            int il = 1;
            try
            {
                //  RegistryKey MyReg = Registry.CurrentUser.OpenSubKey(str);
                //  Console.WriteLine(str + "\\");
                // var subKeys = MyReg.GetSubKeyNames();
                //  Console.WriteLine(subKeys);
                //  foreach (string str2 in subKeys)
                //  {
                //      Console.WriteLine(str2);
                //  }
                RegistryKey OurKey = Registry.CurrentUser;
                OurKey = OurKey.OpenSubKey(str, true);
                foreach (string Keyname in OurKey.GetValueNames())
                {
                    try
                    {
                        using (RegistryKey key = Registry.CurrentUser.OpenSubKey(str))
                        {
                            if (key != null)
                            {
                                try
                                {
                                    var value = (byte[])key.GetValue(Keyname);
                                    var valueAsString = BitConverter.ToString(value);
                                    if (il <= 10)
                                    {
                                        string res = valueAsString.Replace(@"-", @",");
                                        Reg1[il] = Keyname;
                                        il++;
                                        Reg1[il] = res.ToLower();
                                        il++;
                                    }
                                }
                                catch (Exception) { }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        
                    }
                }
                return Reg1;
            }
            catch (Exception)
            {
                
            }
            return Reg1;
        }
    }
}
