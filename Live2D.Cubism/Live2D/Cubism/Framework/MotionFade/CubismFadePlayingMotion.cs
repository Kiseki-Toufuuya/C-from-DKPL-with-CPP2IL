namespace Live2D.Cubism.Framework.MotionFade;

public struct CubismFadePlayingMotion
{
	[SerializeField]
	public float StartTime; //Field offset: 0x0
	[SerializeField]
	public float EndTime; //Field offset: 0x4
	[SerializeField]
	public float FadeInStartTime; //Field offset: 0x8
	[Range(0, 3.4028235E+38)]
	[SerializeField]
	public float Speed; //Field offset: 0xC
	[SerializeField]
	public CubismFadeMotionData Motion; //Field offset: 0x10
	[SerializeField]
	public bool IsLooping; //Field offset: 0x14
	public float Weight; //Field offset: 0x18
	public Nullable<Int32> InstanceId; //Field offset: 0x1C
	public bool IsAnimationEndEventInvoked; //Field offset: 0x24

}

