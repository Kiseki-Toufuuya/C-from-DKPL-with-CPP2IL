namespace UnityEngine.UIElements.UIR;

internal class VectorImageRenderInfo : LinkedPoolItem<VectorImageRenderInfo>
{
	public int useCount; //Field offset: 0xC
	public GradientRemap firstGradientRemap; //Field offset: 0x10
	public Alloc gradientSettingsAlloc; //Field offset: 0x14

	public VectorImageRenderInfo() { }

	public void Reset() { }

}

