namespace Heqet.Danmaku;

public class DropGroupMotion : DropMotionBase
{
	internal enum DropGroupItemType
	{
		Point = 0,
		Power = 1,
	}

	internal enum MotionType
	{
		A_SmallOne = 0,
		B_SmallGroup = 1,
		C_LargeOne = 2,
		D_LargeGrop = 3,
	}

	[SerializeField]
	private MotionType m_MotionType; //Field offset: 0x10
	[SerializeField]
	private DropGroupItemType m_DropGroupItemType; //Field offset: 0x14
	private int m_CenterCount; //Field offset: 0x18
	[SerializeField]
	private int m_SmallCount; //Field offset: 0x1C
	private int m_LargeCount; //Field offset: 0x20
	[SerializeField]
	private float m_Radius; //Field offset: 0x24
	private List<EffectObjectBase> m_SmallList; //Field offset: 0x28
	private List<EffectObjectBase> m_LargeList; //Field offset: 0x2C
	private int m_SmallEffectId; //Field offset: 0x30
	private int m_LargeEffectId; //Field offset: 0x34

	public DropGroupMotion() { }

	private void CreateDrop(int smallCount, int largeCount) { }

	public virtual void Initialize(Vector3 startPos) { }

	private void OnDestroy() { }

	private void SetLargeGroupPosition(Vector3 startPos) { }

	private void SetSmallGroupPosition(Vector3 startPos) { }

}

