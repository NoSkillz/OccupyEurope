using UnityEngine;
using System.Collections;

public class CameraDrag : MonoBehaviour
{
    public float dragSpeed;
    private Vector3 origin;
    private GUIContent devGui;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            origin = Input.mousePosition;
            return;
        }

        if (!Input.GetMouseButton(0))
        {
            return;
        }

        Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - origin);
        Vector3 move = new Vector3(-pos.x * dragSpeed, -pos.y * dragSpeed, 0);

        transform.Translate(move);
    }


    void OnGUI()
    {
        if (devGui == null)
        {
            devGui = new GUIContent();
            return;
        }
        devGui.text = 
            "Cur: " + Input.mousePosition + "\n" +
            "Origin: " + origin;
        GUI.Box(new Rect(10f, 10f, 250f, 100f), devGui);
    }
}
