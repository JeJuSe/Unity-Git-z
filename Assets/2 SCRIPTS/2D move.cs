using UnityEngine;

public class movement : MonoBehaviour
{
    public float moveSpeed;

    void Update()
    {
        // 오른쪽(x축 양의 방향)으로 moveSpeed 속도로 이동
        this.transform.position += Vector3.right * moveSpeed * Time.deltaTime;
    }
}