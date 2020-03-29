using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouteController : MonoBehaviour
{
    public enum RouteVector
    {
        Horizontal,
        Vertical
    }
    public RouteVector Vector;
    // Start is called before the first frame update
    void Start()
    {
        if(Vector == RouteVector.Horizontal)
        {
            Screen.orientation = ScreenOrientation.AutoRotation;
            Screen.autorotateToPortrait = false;
            Screen.autorotateToPortraitUpsideDown = false;
            Screen.autorotateToLandscapeLeft = true;
            Screen.autorotateToLandscapeRight = true;
        }
        else if(Vector == RouteVector.Vertical)
        {
            Screen.orientation = ScreenOrientation.Portrait;
            Screen.autorotateToPortrait = true;
            Screen.autorotateToPortraitUpsideDown = true;
            Screen.autorotateToLandscapeLeft = false;
            Screen.autorotateToLandscapeRight = false;
        }
        else
        {
            Debug.LogError("Error: Invalid Vector");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
