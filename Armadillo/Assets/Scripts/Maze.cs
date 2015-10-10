using UnityEngine;
using System.Collections;

public class Maze {
	// Output
	public Texture2D tiles;
	public int w, h;

	// Privates
	private	Color[] pixels;

	public Maze(int w, int h) {
		this.w = w; this.h = h;
		tiles = new Texture2D (w, h);
		pixels = tiles.GetPixels (0, 0, w, h);	
	}

	public void generate() {
		for(int i = 0; i < w*h; i++)
			pixels[i] = Color.black; 
	}
}
