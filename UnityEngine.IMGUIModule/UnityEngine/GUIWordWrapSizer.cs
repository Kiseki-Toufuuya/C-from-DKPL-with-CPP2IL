namespace UnityEngine;

internal sealed class GUIWordWrapSizer : GUILayoutEntry
{
	private readonly GUIContent m_Content; //Field offset: 0x38
	private readonly float m_ForcedMinHeight; //Field offset: 0x3C
	private readonly float m_ForcedMaxHeight; //Field offset: 0x40

	public GUIWordWrapSizer(GUIStyle style, GUIContent content, GUILayoutOption[] options) { }

	public virtual void CalcHeight() { }

	public virtual void CalcWidth() { }

}

