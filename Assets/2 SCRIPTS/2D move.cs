using UnityEngine;

public class movement : MonoBehaviour
{
    public float moveSpeed;

    void Update()
    {
        // ������(x�� ���� ����)���� moveSpeed �ӵ��� �̵�
        this.transform.position += Vector3.right * moveSpeed * Time.deltaTime;
    }
}