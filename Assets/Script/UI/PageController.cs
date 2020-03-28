using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PageController : MonoBehaviour
{
    [Serializable]
    public class Item
    {
        public Button triggerButton;
        public GameObject pageObject;
    }
    public int nowPage = 0;
    public List<Item> items = new List<Item>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
