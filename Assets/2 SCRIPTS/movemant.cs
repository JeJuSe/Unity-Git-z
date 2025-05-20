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
        Vector3 direction = Vector3.zero;

        if (Input.GetKey(KeyCode.W)) direction += Vector3.forward;
        if (Input.GetKey(KeyCode.S)) direction += Vector3.back;
        if (Input.GetKey(KeyCode.A)) direction += Vector3.left;
        if (Input.GetKey(KeyCode.D)) direction += Vector3.right;

        transform.position += direction.normalized * moveSpeed * Time.deltaTime;
    }
}
