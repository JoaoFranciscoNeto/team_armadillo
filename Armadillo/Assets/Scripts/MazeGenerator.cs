using UnityEngine;
using System.Collections;

public class MazeGenerator : MonoBehaviour {

    public Texture2D tex;
    public Rect sourceRect;

	// Use this for initialization
	void Start () {
        Color[] test = ArrayFromTexture(tex, sourceRect);

        foreach (Color c in test)
        {
            Debug.Log("Color = " + c.r + "," + c.g + "," + c.b);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    Color[] ArrayFromTexture(Texture2D tex, Rect sourceRect)
    {
        int x = Mathf.FloorToInt(sourceRect.x);
        int y = Mathf.FloorToInt(sourceRect.y);

        int width = Mathf.FloorToInt(sourceRect.width);
        int height = Mathf.FloorToInt(sourceRect.height);

        return (tex.GetPixels(x, y, width, height));

    }

}
