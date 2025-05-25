using System;
using UnityEngine;

public class StudyGameobject : MonoBehaviour
{
    public GameObject prefab;

    void Awaket()
    {
        CreateAmongus();
    }

    public void CreateAmongus()
    {
        if (prefab == null)
        {
            Debug.LogError("prefab이 할당되지 않았습니다.");
            return;
        }

        GameObject obj = Instantiate(prefab);
        obj.name = "어몽어스 캐릭터";

        int count = obj.transform.childCount;
        Debug.Log($"캐릭터의 자식 오브젝트의 수 : {count}");

        if (count > 0)
        {
            Debug.Log($"캐릭터의 첫번째 자식 오브젝트의 이름 : {obj.transform.GetChild(0).name}");
            Debug.Log($"캐릭터의 마지막 자식 오브젝트의 이름 : {obj.transform.GetChild(count - 1).name}");
        }
        else
        {
            Debug.Log("자식 오브젝트가 없습니다.");
        }
    }
}