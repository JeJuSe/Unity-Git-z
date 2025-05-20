using UnityEngine;

public class newMonoBehaviourScript : MonoBehaviour
{
    public float moveSpeed; // float = 기본값 0f;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Hello, World!");
    
        //this.transform.position = this.transform.position + Vector3.forward;
        //this.transform.position += Vector3.forward;

        //Debug.Log($"현재 z축의 값은 {this.transform.position.z}입니다.");
    }
    // Update is called once per frame
    void Update()
    {
        this.transform.position = this.transform.position + Vector3.forward * moveSpeed;

        this.GetComponent < Rigidbody>().linearVelocity = Vector3.forward * moveSpeed;
    }                                                //현재 속도 = 현재 속도 0.98+- 감속 시키는 변수
}