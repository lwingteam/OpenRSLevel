using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelsListItem : MonoBehaviour
{
    public Button PlayButton;
    public Text NameText;
    public Text AuthorText;
    public Text VersionText;
    public Text ApiText;
    public Button EditButton;
    // Start is called before the first frame update
    void Start()
    {
        bindEvent();
    }
    public void render(Level LevelObject)
    {
        NameText.text = LevelObject.name;
        AuthorText.text = LevelObject.author;
        VersionText.text = LevelObject.version;
        ApiText.text = "" + LevelObject.apiversion;
    }
    public void bindEvent()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
