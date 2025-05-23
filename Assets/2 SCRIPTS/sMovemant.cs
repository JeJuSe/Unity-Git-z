using UnityEngine;

public class PlayMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        // 부드럽게 증감하는 값
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // 딱 떨어지는 값
        // float h = Input.GetAxisRaw("Horizontal");
        // float v = Input.GetAxisRaw("Vertical");

        Vector3 dir = new Vector3(h, 0, v);

        Vector3 normalDir = dir.normalized; // 정규화 과정 (0 ~ 1)


        //Debug.Log($"현재 입력 : {normalDir}");

        transform.position += normalDir * moveSpeed * Time.deltaTime;

        transform.LookAt(transform.position + normalDir); // 바라보는 방향을 바꿔줌

    }
}