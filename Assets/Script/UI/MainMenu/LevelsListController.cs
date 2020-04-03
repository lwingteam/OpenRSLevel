using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Threading.Tasks;
public class LevelsListController : MonoBehaviour
{
    List<Level> levelsCache = new List<Level>();
    public GameObject ItemTemplate;
    List<LevelsListItem> Items = new List<LevelsListItem>();
    public GameObject Viewport;
    private static string datapath;
    void Start()
    {
        datapath = FileUtils.PublicDataPath;
        
        Task.Run(() =>
        {
            Debug.Log("Loading Levels List by Task, DataPath=" + datapath);
            reload();
            renderList();
            clearCache();
        });
    }
    void reload()
    {
        clearCache();
        foreach (var item in Directory.GetFiles(datapath))
        {
            if (item.EndsWith(".orlp"))
            {
                Level levelobj = LevelLoader.LoadLevelFromFile(item);
                if (levelobj != null)
                {
                    levelsCache.Add(levelobj);
                }
            }
        }
    }
    void renderList()
    {
        for (int i = 0; i < levelsCache.Count; i++)
        {
            GameObject item = Instantiate(ItemTemplate, Viewport.transform);
            item.GetComponent<LevelsListItem>().render(levelsCache[i]);
        }
    }
    void clearCache()
    {
        levelsCache.Clear();
        GC.Collect();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
