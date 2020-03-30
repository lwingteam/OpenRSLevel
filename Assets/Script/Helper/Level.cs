using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
[Serializable]
public class Level
{
    public string name;
    public string version;
    public List<List<string>> map;
}
public class LevelLoader
{
    public Level LoadLevelFromString(string str)
    {
        return new Level();
    }
    public Level LoadLevelFromFile(string path)
    {
        return LoadLevelFromString(File.ReadAllText(path));
    }

    public string GetLevelDataFromObject(Level obj)
    {
        return "";
    }
}
