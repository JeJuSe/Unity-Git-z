using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;

// ���������� Ŭ������ ����Ƽ�� ������ ����� ����ִ� ��
public class StudyComponent : MonoBehaviour
{
    public GameObject obj;

    public Mesh msh;
    public Material mat;


    void Start()
    {
        obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //CreateCube(); // �Լ� ����,ȣ��
    }

    public void CreateCube()
    {

        // obj = new GameObject();
        // obj.name = "Cube";
        obj = new GameObject("Cube");

        obj.AddComponent<MeshFilter>();
        obj.GetComponent<MeshFilter>().mesh = msh;

        obj.AddComponent<MeshRenderer>();
        obj.GetComponent<MeshRenderer>().material = mat;

        obj.AddComponent<BoxCollider>();

    }





    ////���������� Ÿ�� ������;
    //public GameObject obj;

    //public Transform objTf;

    ////public string changeName;
    ////���������� Ÿ�� �����̸�

    //void Start()
    //{
    //    ////obj = GameObject.Find("Main Camera");//Main camera ������Ʈ�� ã�Ƽ� �Ҵ��ϴ� ���
    //    ////��Ʈ�� k c /k u  ��Ʈ�� ������


    //    ////1
    //    //obj = GameObject.FindGameObjectWithTag("Player");
    //    ////���� ������Ʈ�� �±׿� �Բ� ã�ڴ�
    //    ////obj.name = changeName;

    //    ////Debug.Log($"�̸� : {obj.name}"); // ���ӿ�����Ʈ�� �̸�
    //    ////Debug.Log($"<color=#FF0000>�̸� : {obj.name}</color>"); // ���ӿ�����Ʈ�� �̸�
    //    ////Debug.Log($"�±� : {obj.tag}"); // ���ӿ�����Ʈ�� �±�
    //    ////Debug.Log($"��ġ : {obj.transform.position}"); // ���ӿ�����Ʈ�� Transform ������Ʈ�� ��ġ
    //    ////Debug.Log($"ȸ�� : {obj.transform.rotation}"); // ���ӿ�����Ʈ�� Transform ������Ʈ�� ȸ��
    //    ////Debug.Log($"ũ�� : {obj.transform.localScale}"); // ���ӿ�����Ʈ�� Transform ������Ʈ�� ũ��

    //    ////meshFilter ������Ʈ�� �����ؼ� mesh�� log �޼����� ����ϴ� ���
    //    ////Debug.Log($"Mesh ������ : {obj.GetComponent<MeshFilter>().mesh}");

    //    //////MeshRenderer ������Ʈ�� �����ؼ� material�� log �޼����� ����ϴ� ���
    //    ////Debug.Log($"Material ������ : {obj.GetComponent<MeshRenderer>().material}");

    //    ////2
    //    ////Player��� Tag�� ���� ���Ӥ�������Ʈ�� ã�Ƽ� obj�� �Ҵ�
    //    //objTf = GameObject.FindGameObjectWithTag("Player").transform; //

    //    //objTf.gameObject.SetActive(false);


    //    ////3
    //    //// obj�� MeshRenderer�� �����ؼ� Ȱ�����¸� false�� �����ϰڴ�.
    //    //obj.GetComponent<MeshRenderer>().enabled = false;
    //    ////            GetComponent<������Ÿ��>()        

    //    ////c
    //    ////obj�� GmaeObject Ȱ�����¸� false (���� ���)
    //    //obj.SetActive(false);


    //}


}
