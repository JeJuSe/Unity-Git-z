using UnityEngine;

public class movemant : MonoBehaviour
{
    public float moveSpeed = 10f;
    // float moveSpeed1; //*private )
    void Start()
    {
        //this.transform.position = this.transform.position + Vector3.forward;
    }  //Transform의 Posittion(위치) 현재 위치     (0,0,1)

    // Update is called once per frame
    void Update()
    {
        //his.transform.position = this.transform.position + Vector3.forward * moveSpeed;
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
    }
}
