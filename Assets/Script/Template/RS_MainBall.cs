using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RS_MainBall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateBallPosX();
    }

    float GetMouseXPos()    //获取鼠标X坐标
    {
        Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition + new Vector3(0, 0, 10)); //反正就要加"+new Vector3(0, 0, 10)"不加不行，我也不知道为什么
        return MousePos.x;
    }

    void UpdateBallPosX()  //更新球的X坐标
    {
        this.gameObject.transform.position = new Vector3(GetMouseXPos(), this.gameObject.transform.position.y, this.gameObject.transform.position.z);
    }
}
