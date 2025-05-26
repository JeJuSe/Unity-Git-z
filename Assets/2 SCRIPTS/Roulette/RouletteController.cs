using UnityEngine;

public class RouletteController : MonoBehaviour
{
    public float rotSpeed;

    public bool isStop; // false

    private void Start()
    {
        rotSpeed = 0f;
    }



    private void Update()
    {
        transform.Rotate(Vector3.forward * rotSpeed);

        //마우스 왼쪽 버튼을 눌렀을 때 회전하는 기능.
        if (Input.GetMouseButtonDown(0))
        {
            rotSpeed = 5f;
        }
        
        //transform.Rotate(0f, 0f, rotSpeed);

        // 킵드 스페이스 버튼을 눌렀을 때 -> 1번 실행
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isStop = true;
        }

        if (isStop == true)
        {
            rotSpeed *= 0.98f; // 회전 속도를 점점 줄임

            if (rotSpeed < 0.01f)
            {
                rotSpeed = 0f; 
                isStop = false; // 정지 상태를 해제

            }
            
            // rotSpeed = 0 f; 
            // 회전 속도를 0으로 설정하여 정지
            // isStop = false; // 정지 상태를 해제
            //rotSpeed = 0f;
            // isStop = false;
        }
        
        // rouSpeed = rotSpeed * 0.98f;
      //  rotSpeed *= 0.98f;


        // vector3.forward = new Vector3(0f, 0f, 1f);

    }

}