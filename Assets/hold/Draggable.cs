using UnityEngine;

public class Draggable : MonoBehaviour
{
    private Vector3 offset;
    private float zCoord;
    private Vector3 startPos;
    private bool isDragging = false;

    void Start()
    {
        startPos = transform.position;
    }

    void OnMouseDown()
    {
        zCoord = Camera.main.WorldToScreenPoint(transform.position).z;
        offset = transform.position - GetMouseWorldPos();
        isDragging = true;
    }

    void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + offset;
    }

    void OnMouseUp()
    {
        isDragging = false;

        // DropZone�� �ִ��� Ȯ��
        Collider2D hit = Physics2D.OverlapPoint(transform.position);
        if (hit != null && hit.CompareTag("DropZone"))
        {
            // �ùٸ� ��ġ�� ��ӵ�
            Debug.Log("Dropped on valid zone");
        }
        else
        {
            // �߸��� ��ġ, ���� �ڸ��� �̵�
            transform.position = startPos;
        }
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = zCoord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
}