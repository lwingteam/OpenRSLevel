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
        for (int i = 0; i < items.Count; i++)
        {
            var item = items[i];
            var obj = item.triggerButton.gameObject;
            var trigger = obj.AddComponent<PageButtonTrigger>();
            trigger.controller = this;
            trigger.index = i;
        }
        ChangePage(0);
    }
    public void ChangePage(int b)
    {
        nowPage = b;
        for (int i = 0; i < items.Count; i++)
        {
            items[i].pageObject.SetActive(false);
        }
        items[b].pageObject.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {

    }
    class PageButtonTrigger : MonoBehaviour
    {
        public PageController controller;
        public int index;
        void Start()
        {
            var eventobj = GetComponent<Button>().onClick;
            eventobj.AddListener(() =>
            {
                controller.ChangePage(index);
            });
        }
        void Update()
        {

        }
    }
}
