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

        //���콺 ���� ��ư�� ������ �� ȸ���ϴ� ���.
        if (Input.GetMouseButtonDown(0))
        {
            rotSpeed = 5f;
        }
        
        //transform.Rotate(0f, 0f, rotSpeed);

        // ŵ�� �����̽� ��ư�� ������ �� -> 1�� ����
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isStop = true;
        }

        if (isStop == true)
        {
            rotSpeed *= 0.98f; // ȸ�� �ӵ��� ���� ����

            if (rotSpeed < 0.01f)
            {
                rotSpeed = 0f; 
                isStop = false; // ���� ���¸� ����

            }
            
            // rotSpeed = 0 f; 
            // ȸ�� �ӵ��� 0���� �����Ͽ� ����
            // isStop = false; // ���� ���¸� ����
            //rotSpeed = 0f;
            // isStop = false;
        }
        
        // rouSpeed = rotSpeed * 0.98f;
      //  rotSpeed *= 0.98f;


        // vector3.forward = new Vector3(0f, 0f, 1f);

    }

}