using UnityEngine;


public class player : MonoBehaviour
{
    [Header("腳色移動速度"),Range(0.1f,10.0f)]
    public float speed = 0.5f;

    public Rigidbody rig;
    
    public void Move()   //腳色移動//
    {
        
        float ws = Input.GetAxis("Vertical");                                  //浮點數名稱,輸入,拿到前後左右軸,內建前後移動名稱
        float ad = Input.GetAxis("Horizontal");                                //浮點數名稱,輸入,拿到前後左右軸,內建左右移動名稱
        Vector3 ww = transform.forward * ws+ transform.right*ad;               //三維向量名稱,轉換,前後乘上,按鍵輸入名稱+左右乘上按鍵輸入名稱
        rig.MovePosition(transform.position + ww* speed);                      //鋼體名稱,移動位置名稱,轉換物件位置,加上三維向量名稱呈上速度
    }


    private void Update()
    {
        Move();                         //腳色移動//
    }

}
