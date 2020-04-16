using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RS_MainBall : MonoBehaviour
{
    public float FSpeed = 0f; //向前移动的速度
    public float JumpForce = 1200f; //跳跃的力度
    private Rigidbody RS_MainBallR = null;
    // Start is called before the first frame update
    void Start()
    {
        this.RS_MainBallR = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Physics.gravity = new Vector3(0, -35, 0);   //加快物体下落速度
        UpdateBallPosX();
        UpdateBallPosZ();
    }

    float GetMouseXPos()    //获取鼠标X坐标
    {
        Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition + new Vector3(0, 0, 10)); //反正就要加"+new Vector3(0, 0, 10)"不加不行，我也不知道为什么
        return MousePos.x;
    }

    void UpdateBallPosX()  //更新球的X坐标
    {
        this.gameObject.transform.Translate(Vector3.right * GetBallSpeed() * Time.deltaTime);
    }

    float GetBallSpeed() //获取球的移动速度
    {
        float BallSpeed = (GetMouseXPos() - this.transform.position.x) * 11.5f;  //这里的11.5为速度乘数。11.5最接近官方，我认为6左右手感最佳(该数据是对电脑而言，手机可能不同)。（这个数值越大越灵敏）

        return BallSpeed;
    }

    void UpdateBallPosZ() //更新球的Z坐标
    {
        this.gameObject.transform.Translate(Vector3.forward * FSpeed * Time.deltaTime);
    }

    void BallJump() //跳跃
    {
        this.RS_MainBallR.velocity = new Vector3(this.RS_MainBallR.velocity.x, JumpForce, this.RS_MainBallR.velocity.z);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "JumpB")
            BallJump();
    }

    void Restart() //重新开始
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
