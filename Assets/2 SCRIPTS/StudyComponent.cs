using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;

// 접근제한자 클래스명 유니티의 유용한 기능이 들어있는 곳
public class StudyComponent : MonoBehaviour
{
    public GameObject obj;

    public Mesh msh;
    public Material mat;


    void Start()
    {
        obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //CreateCube(); // 함수 실행,호출
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





    ////접근제한자 타입 변수명;
    //public GameObject obj;

    //public Transform objTf;

    ////public string changeName;
    ////접근제한자 타입 변수이름

    //void Start()
    //{
    //    ////obj = GameObject.Find("Main Camera");//Main camera 오브젝트를 찾아서 할당하는 기능
    //    ////컨트롤 k c /k u  컨트롤 슬래시


    //    ////1
    //    //obj = GameObject.FindGameObjectWithTag("Player");
    //    ////게임 오브젝트를 태그와 함께 찾겠다
    //    ////obj.name = changeName;

    //    ////Debug.Log($"이름 : {obj.name}"); // 게임오브젝트의 이름
    //    ////Debug.Log($"<color=#FF0000>이름 : {obj.name}</color>"); // 게임오브젝트의 이름
    //    ////Debug.Log($"태그 : {obj.tag}"); // 게임오브젝트의 태그
    //    ////Debug.Log($"위치 : {obj.transform.position}"); // 게임오브젝트의 Transform 컴포넌트의 위치
    //    ////Debug.Log($"회전 : {obj.transform.rotation}"); // 게임오브젝트의 Transform 컴포넌트의 회전
    //    ////Debug.Log($"크기 : {obj.transform.localScale}"); // 게임오브젝트의 Transform 컴포넌트의 크기

    //    ////meshFilter 컴포넌트에 접근해서 mesh를 log 메세지로 출력하는 기능
    //    ////Debug.Log($"Mesh 데이터 : {obj.GetComponent<MeshFilter>().mesh}");

    //    //////MeshRenderer 컴포넌트에 접근해서 material을 log 메세지로 출력하는 기능
    //    ////Debug.Log($"Material 데이터 : {obj.GetComponent<MeshRenderer>().material}");

    //    ////2
    //    ////Player라는 Tag를 가진 게임ㅇ오브젝트를 찾아서 obj에 할당
    //    //objTf = GameObject.FindGameObjectWithTag("Player").transform; //

    //    //objTf.gameObject.SetActive(false);


    //    ////3
    //    //// obj의 MeshRendererㅇ 접근해서 활성상태를 false로 변경하겠다.
    //    //obj.GetComponent<MeshRenderer>().enabled = false;
    //    ////            GetComponent<데이터타입>()        

    //    ////c
    //    ////obj의 GmaeObject 활성상태를 false (끄는 기능)
    //    //obj.SetActive(false);


    //}


}
