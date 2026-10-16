namespace Cinemachine.Utility;

public class HeadingTracker
{
	private struct Item
	{
		public Vector3 velocity; //Field offset: 0x0
		public float weight; //Field offset: 0xC
		public float time; //Field offset: 0x10

	}

	private static float mDecayExponent; //Field offset: 0x0
	private Item[] mHistory; //Field offset: 0x8
	private int mTop; //Field offset: 0xC
	private int mBottom; //Field offset: 0x10
	private int mCount; //Field offset: 0x14
	private Vector3 mHeadingSum; //Field offset: 0x18
	private float mWeightSum; //Field offset: 0x24
	private float mWeightTime; //Field offset: 0x28
	private Vector3 mLastGoodHeading; //Field offset: 0x2C

	public int FilterSize
	{
		 get { } //Length: 23
	}

	public HeadingTracker(int filterSize) { }

	public void Add(Vector3 velocity) { }

	private void ClearHistory() { }

	private static float Decay(float time) { }

	public void DecayHistory() { }

	public int get_FilterSize() { }

	public Vector3 GetReliableHeading() { }

	private void PopBottom() { }

}

