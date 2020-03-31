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
    void Start()
    {
        reload().GetAwaiter().OnCompleted(() =>
        {
            renderList();
            clearCache();
        });
    }
    Task reload()
    {
        Task r = new Task(() =>
        {
            clearCache();
            //扫描关卡文件
            Debug.Log(FileUtils.PublicDataPath);
            foreach (var item in Directory.GetFiles(FileUtils.PublicDataPath))
            {
                if (item.EndsWith(".orlp"))
                {
                    levelsCache.Add(LevelLoader.LoadLevelFromFile(item));
                }
            }
        });
        r.Start();
        return r;
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
