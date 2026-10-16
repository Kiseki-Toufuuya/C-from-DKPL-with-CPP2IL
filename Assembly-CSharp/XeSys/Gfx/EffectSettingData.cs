namespace XeSys.Gfx;

public struct EffectSettingData
{
	internal AnimationType m_AnimType; //Field offset: 0x0
	internal int m_loopNum; //Field offset: 0x4
	internal bool m_IsAutoEnd; //Field offset: 0x8

	public EffectSettingData(AnimationType animtype, int loopeNum, bool isAutoEnd) { }

}

