namespace UnityEngine.Rendering.PostProcessing;

internal class TargetPool
{
	private readonly List<Int32> m_Pool; //Field offset: 0x8
	private int m_Current; //Field offset: 0xC

	internal TargetPool() { }

	internal int Get() { }

	private int Get(int i) { }

	internal void Reset() { }

}

