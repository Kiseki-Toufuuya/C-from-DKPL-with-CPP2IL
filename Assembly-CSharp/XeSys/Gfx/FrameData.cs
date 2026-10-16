namespace XeSys.Gfx;

public struct FrameData
{
	internal enum FrameAction
	{
		none = 0,
		stop = 1,
		loop = 2,
		jump = 3,
	}

	public int FrameIdx; //Field offset: 0x0
	public float Time; //Field offset: 0x4
	public string TexName; //Field offset: 0x8
	public AnimViewTransformData TransFormData; //Field offset: 0xC
	public FrameAction Action; //Field offset: 0x58
	public float JumpFrame; //Field offset: 0x5C

}

