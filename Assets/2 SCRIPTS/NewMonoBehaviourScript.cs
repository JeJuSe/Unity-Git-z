using UnityEngine;

public class newMonoBehaviourScript : MonoBehaviour
{
    public float moveSpeed; // float = �⺻�� 0f;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Hello, World!");
    
        //this.transform.position = this.transform.position + Vector3.forward;
        //this.transform.position += Vector3.forward;

        //Debug.Log($"���� z���� ���� {this.transform.position.z}�Դϴ�.");
    }
    // Update is called once per frame
    void Update()
    {
        this.transform.position = this.transform.position + Vector3.forward * moveSpeed;

        this.GetComponent < Rigidbody>().linearVelocity = Vector3.forward * moveSpeed;
    }                                                //���� �ӵ� = ���� �ӵ� 0.98+- ���� ��Ű�� ����
}