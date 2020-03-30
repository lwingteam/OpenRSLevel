using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class LevelsListController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //扫描关卡文件
        Debug.Log(FileUtils.PublicDataPath);
        foreach (var item in Directory.GetFiles(FileUtils.PublicDataPath, "(*.orlf)", SearchOption.TopDirectoryOnly))
        {
            Debug.Log(item);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
