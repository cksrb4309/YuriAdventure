using Unity.VisualScripting;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    private Camera cam;
    private bool isSelected =false;

    private void Awake()
    {
        cam = Camera.main;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        DropManager.Instance.emptyPositionX = gameObject.GetComponent<Drop>().positionX;
        DropManager.Instance.emptyPositionY = gameObject.GetComponent<Drop>().positionY;
        Debug.Log(DropManager.Instance.emptyPositionX.ToString());
        Debug.Log(DropManager.Instance.emptyPositionY.ToString());
        isSelected = true;
    }

    private void OnMouseUp()
    {
        isSelected = false;
        DropManager.Instance.state = DropManager.State.Wait;
        gameObject.GetComponent<Drop>().Move(DropManager.Instance.emptyPositionX, DropManager.Instance.emptyPositionY);
    }

    private void OnMouseDrag()
    {
        transform.position = GetMousePos();
        DropManager.Instance.state = DropManager.State.Moving;
    }

    //private void OnMouseOver()
    //{
    //    if (isSelected)
    //    {
    //        return;
    //    }
    //    if(DropManager.Instance.state == DropManager.State.Wait)
    //    {
    //        return;
    //    }
    //    if(DropManager.Instance.state == DropManager.State.Moving)
    //    {
    //        Drop drop = gameObject.GetComponent<Drop>();
    //        int x = drop.positionX;
    //        int y = drop.positionY;
    //        gameObject.GetComponent<Drop>().Move(DropManager.Instance.emptyPositionX, DropManager.Instance.emptyPositionY);
    //        DropManager.Instance.emptyPositionX = x;
    //        DropManager.Instance.emptyPositionY = y;
    //    }
    //}

    private void OnMouseEnter()
    {
        if (DropManager.Instance.state == DropManager.State.Wait)
        {
            return;
        }
        if (DropManager.Instance.state == DropManager.State.Moving)
        {
            Drop drop = gameObject.GetComponent<Drop>();
            int x = drop.positionX;
            int y = drop.positionY;
            gameObject.GetComponent<Drop>().Move(DropManager.Instance.emptyPositionX, DropManager.Instance.emptyPositionY);
            DropManager.Instance.emptyPositionX = x;
            DropManager.Instance.emptyPositionY = y;
        }
    }

    Vector3 GetMousePos()
    {
        Vector3 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;

        return mousePos;
    }
}
