using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class ItemDrag : MonoBehaviour//, IPointerClickHandler
{
   /* public void OnPointerClick(PointerEventData aEventData)
    {
        if (aEventData.button == PointerEventData.InputButton.Left)
        Debug.Log(aEventData.selectedObject.name);
        Debug.Log("sajt");
    }
    */
	// Use this for initialization
    float distance;
	void Start () {
        distance = transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
   
    void OnMouseDrag() {
        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 newPos = Camera.main.ScreenToWorldPoint(mousePos);
        newPos.z = distance;
        transform.position = newPos;
    }
}
