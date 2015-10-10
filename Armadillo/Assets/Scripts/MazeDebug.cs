using UnityEngine;
using System.Collections;

public class MazeDebug : MonoBehaviour {

	Maze maze;
	public Texture aTexture;

	// Use this for initialization
	void Start () {
		maze = new Maze (32, 32);
		maze.generate ();

		aTexture = maze.tiles;
	}

	void OnGUI() {
		if (!aTexture) {
			Debug.LogError("Assign a Texture in the inspector.");
			return;
		}
		GUI.DrawTexture(new Rect(10, 10, maze.w*16, maze.h*16), aTexture, ScaleMode.ScaleToFit, true, 0);
	}
}
