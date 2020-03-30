using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class FileUtils
{
    public static string PublicDataPath
    {
        get
        {
            string result = Application.persistentDataPath;
            if (Application.platform == RuntimePlatform.Android)
            {
                if (result.IndexOf("sdcard") == -1 && result.IndexOf("storage/emulated") == -1)
                {
                    result = "/storage/emulated/" + result;
                }
                if (!Directory.Exists(result))
                {
                    safeCreateDir(result);
                }
            }
            return result;
        }
    }
    public static bool safeCreateDir(string dir)
    {
        string realdir = dir.Replace('\\', '/');
        string buffer = "";
        foreach (var item in realdir.Split(new char[] { '/' } ,System.StringSplitOptions.RemoveEmptyEntries))
        {
            buffer += "/" + item;
            try
            {
                if (!Directory.Exists(buffer))
                {
                    Directory.CreateDirectory(buffer);
                }
            }
            catch
            {
                return false;
            }
        }
        return true;
    }
}
