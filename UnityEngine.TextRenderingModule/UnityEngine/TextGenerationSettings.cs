namespace UnityEngine;

public struct TextGenerationSettings
{
	public Font font; //Field offset: 0x0
	public Color color; //Field offset: 0x4
	public int fontSize; //Field offset: 0x14
	public float lineSpacing; //Field offset: 0x18
	public bool richText; //Field offset: 0x1C
	public float scaleFactor; //Field offset: 0x20
	public FontStyle fontStyle; //Field offset: 0x24
	public TextAnchor textAnchor; //Field offset: 0x28
	public bool alignByGeometry; //Field offset: 0x2C
	public bool resizeTextForBestFit; //Field offset: 0x2D
	public int resizeTextMinSize; //Field offset: 0x30
	public int resizeTextMaxSize; //Field offset: 0x34
	public bool updateBounds; //Field offset: 0x38
	public VerticalWrapMode verticalOverflow; //Field offset: 0x3C
	public HorizontalWrapMode horizontalOverflow; //Field offset: 0x40
	public Vector2 generationExtents; //Field offset: 0x44
	public Vector2 pivot; //Field offset: 0x4C
	public bool generateOutOfBounds; //Field offset: 0x54

	private bool CompareColors(Color left, Color right) { }

	private bool CompareVector2(Vector2 left, Vector2 right) { }

	public bool Equals(TextGenerationSettings other) { }

}

