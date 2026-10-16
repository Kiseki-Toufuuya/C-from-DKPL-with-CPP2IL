namespace UnityEngine;

[NativeHeader("Modules/IMGUI/GUISkin.bindings.h")]
public sealed class GUISettings
{
	[SerializeField]
	private bool m_DoubleClickSelectsWord; //Field offset: 0x8
	[SerializeField]
	private bool m_TripleClickSelectsLine; //Field offset: 0x9
	[SerializeField]
	private Color m_CursorColor; //Field offset: 0xC
	[SerializeField]
	private float m_CursorFlashSpeed; //Field offset: 0x1C
	[SerializeField]
	private Color m_SelectionColor; //Field offset: 0x20

	public Color cursorColor
	{
		 get { } //Length: 18
	}

	public float cursorFlashSpeed
	{
		 get { } //Length: 71
	}

	public bool doubleClickSelectsWord
	{
		 get { } //Length: 11
	}

	public Color selectionColor
	{
		 get { } //Length: 18
	}

	public bool tripleClickSelectsLine
	{
		 get { } //Length: 11
	}

	public GUISettings() { }

	public Color get_cursorColor() { }

	public float get_cursorFlashSpeed() { }

	public bool get_doubleClickSelectsWord() { }

	public Color get_selectionColor() { }

	public bool get_tripleClickSelectsLine() { }

	private static float Internal_GetCursorFlashSpeed() { }

}

