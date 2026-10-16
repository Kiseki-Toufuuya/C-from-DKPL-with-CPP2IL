namespace UnityEngine.UIElements;

public sealed class VectorImage : ScriptableObject
{
	[SerializeField]
	internal int version; //Field offset: 0xC
	[SerializeField]
	internal Texture2D atlas; //Field offset: 0x10
	[SerializeField]
	internal VectorImageVertex[] vertices; //Field offset: 0x14
	[SerializeField]
	internal UInt16[] indices; //Field offset: 0x18
	[SerializeField]
	internal GradientSettings[] settings; //Field offset: 0x1C
	[SerializeField]
	internal Vector2 size; //Field offset: 0x20

	public float height
	{
		 get { } //Length: 11
	}

	public float width
	{
		 get { } //Length: 11
	}

	public VectorImage() { }

	public float get_height() { }

	public float get_width() { }

}

