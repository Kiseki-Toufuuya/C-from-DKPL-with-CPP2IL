//Type is in global namespace

public class ContentSizeFitterEx : ContentSizeFitter
{
	public Vector2 sizeMin; //Field offset: 0x20
	public Vector2 sizeMax; //Field offset: 0x28

	public ContentSizeFitterEx() { }

	public virtual void SetLayoutHorizontal() { }

	public virtual void SetLayoutVertical() { }

}

