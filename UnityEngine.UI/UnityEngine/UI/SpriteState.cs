namespace UnityEngine.UI;

public struct SpriteState : IEquatable<SpriteState>
{
	[SerializeField]
	private Sprite m_HighlightedSprite; //Field offset: 0x0
	[SerializeField]
	private Sprite m_PressedSprite; //Field offset: 0x4
	[FormerlySerializedAs("m_HighlightedSprite")]
	[SerializeField]
	private Sprite m_SelectedSprite; //Field offset: 0x8
	[SerializeField]
	private Sprite m_DisabledSprite; //Field offset: 0xC

	public Sprite disabledSprite
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public Sprite highlightedSprite
	{
		 get { } //Length: 10
		 set { } //Length: 23
	}

	public Sprite pressedSprite
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public Sprite selectedSprite
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public override bool Equals(SpriteState other) { }

	public Sprite get_disabledSprite() { }

	public Sprite get_highlightedSprite() { }

	public Sprite get_pressedSprite() { }

	public Sprite get_selectedSprite() { }

	public void set_disabledSprite(Sprite value) { }

	public void set_highlightedSprite(Sprite value) { }

	public void set_pressedSprite(Sprite value) { }

	public void set_selectedSprite(Sprite value) { }

}

