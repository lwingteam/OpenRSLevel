using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RS_MainCamera : MonoBehaviour
{
    public GameObject MainBall = null; //球
    public float BackBallDistance = 10f; //摄像机在球的后面的距离 (推荐值是10，我发现这个数会影响手感)
    private float MainBallStartPosX = 0f; //球的初始x坐标
    // Start is called before the first frame update
    void Start()
    {
        this.MainBallStartPosX = this.MainBall.gameObject.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateCameraPosZ();
    }

    void UpdateCameraPosZ() //更新摄像机的Z坐标
    {
        this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.MainBall.gameObject.transform.position.z - this.BackBallDistance);
    }
}
