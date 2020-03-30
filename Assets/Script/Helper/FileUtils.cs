using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FileUtils
{
    public static string PublicDataPath
    {
        get
        {
            string result = Application.persistentDataPath;
            if (result.IndexOf("sdcard") == -1 && result.IndexOf("storage/emulated") == -1)
            {
                result = "/storage/emulated/" + result;
            }
            return result;
        }
    }
}
