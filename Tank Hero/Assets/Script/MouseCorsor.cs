using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCorsor : MonoBehaviour {

	//This script is about the crosshair image 

    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

	public Texture2D enterEnemyTexture;
	// Use this for initialization
	void Start () {
		Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
	}
	
	// Update is called once per frame
	void Update () {
		//Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
	}
	public void changeMouseCursor()
	{
		Cursor.SetCursor(enterEnemyTexture, hotSpot, cursorMode);
	}

	public void defaultMouseCursor()
	{
		Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
	}
}
