using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using System.Collections;

public class MapScript : MonoBehaviour
{
    private GUIContent devGui;
    private SpriteRenderer map;
    private Vector3 initialMousePosition;
    private float mouseTravelDistance;
    public float mouseTravelIgnore;
    public float mapMoveMultiplier;

    // Use this for initialization
    public void Start()
    {
        devGui = new GUIContent(string.Empty);
        map = FindObjectOfType<SpriteRenderer>();
    }

    // Update is called once per frame
    public void Update()
    {
        OnMapClick();
    }

    public void OnGUI()
    {
        //GUI.Box(new Rect(10f, 10f, 300f, 100f), devGui);
        //devGui.text = string.Empty;
        //devGui.text += "Pos: " + Input.mousePosition;

        //if (Input.GetMouseButtonDown(0))
        //{
        //    devGui.text += "\nClicked at: " + Input.mousePosition;
        //    initialMousePosition = Input.mousePosition;
        //}

        //if (Input.GetMouseButtonUp(0))
        //{
        //    devGui.text += ("\nReleased at: " + Input.mousePosition);

        //    mouseTravelDistance = Vector3.Distance(initialMousePosition, Input.mousePosition);

        //    Debug.Log(mouseTravelDistance);

        //    if (mouseTravelDistance > mouseTravelIgnore)
        //    {
        //        Debug.Log("Camera should be moving.\nMouse travel distance should be " + mouseTravelDistance * mapMoveMultiplier);
        //        map.transform.Translate(mouseTravelDistance * mapMoveMultiplier, mouseTravelDistance * mapMoveMultiplier, mouseTravelDistance * mapMoveMultiplier);
        //    }
        //}
    }

    private void OnMapClick()
    {


        //if (Input.GetMouseButtonDown(0))
        //{

        //    var initialPosition = Input.mousePosition;
        //    devGui.text = "Mouse down" + "\n" + "Pos: " + Input.mousePosition;

        //    if (HasMouseMoved())
        //    {
        //        devGui.text += "\n" + HasMouseMoved();
        //        map.gameObject.transform.Translate(1f, 1f, 1f);
        //    }

        //}

        //if (Input.GetMouseButtonUp(0))
        //{
        //    devGui.text = "Mouse up" + "\n" + "Pos: " + Input.mousePosition;
        //}
    }
}
