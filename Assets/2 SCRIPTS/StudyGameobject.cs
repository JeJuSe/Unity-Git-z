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
            Debug.LogError("prefab�� �Ҵ���� �ʾҽ��ϴ�.");
            return;
        }

        GameObject obj = Instantiate(prefab);
        obj.name = "���� ĳ����";

        int count = obj.transform.childCount;
        Debug.Log($"ĳ������ �ڽ� ������Ʈ�� �� : {count}");

        if (count > 0)
        {
            Debug.Log($"ĳ������ ù��° �ڽ� ������Ʈ�� �̸� : {obj.transform.GetChild(0).name}");
            Debug.Log($"ĳ������ ������ �ڽ� ������Ʈ�� �̸� : {obj.transform.GetChild(count - 1).name}");
        }
        else
        {
            Debug.Log("�ڽ� ������Ʈ�� �����ϴ�.");
        }
    }
}