using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Newtonsoft.Json;
using System.IO;
[Serializable]
public class Level
{
    public string name = "null";
    public string version = "null";
    public List<List<string>> map;
    public int apiversion = 0;
    public string author = "null";
}
public class LevelLoader
{
    public static Level LoadLevelFromString(string str)
    {
        Level result = null;
        try
        {
            result = JsonConvert.DeserializeObject<Level>(str);
        }
        catch { }
        return result;
    }
    public static Level LoadLevelFromFile(string path)
    {
        return LoadLevelFromString(File.ReadAllText(path));
    }

    public static string GetLevelDataFromObject(Level obj)
    {
        return JsonConvert.SerializeObject(obj);
    }
}
