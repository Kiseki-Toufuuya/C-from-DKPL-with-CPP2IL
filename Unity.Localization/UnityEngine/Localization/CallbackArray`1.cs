namespace UnityEngine.Localization;

internal struct CallbackArray
{
	private const int k_AllocationIncrement = 5; //Field offset: 0x0
	private TDelegate m_SingleDelegate; //Field offset: 0x0
	private TDelegate[] m_MultipleDelegates; //Field offset: 0x0
	private List<TDelegate> m_AddCallbacks; //Field offset: 0x0
	private List<TDelegate> m_RemoveCallbacks; //Field offset: 0x0
	private int m_Length; //Field offset: 0x0
	private bool m_CannotMutateCallbacksArray; //Field offset: 0x0
	private bool m_MutatedDuringCallback; //Field offset: 0x0

	public int Length
	{
		 get { } //Length: 11
	}

	public TDelegate[] MultiDelegates
	{
		 get { } //Length: 11
	}

	public TDelegate SingleDelegate
	{
		 get { } //Length: 10
	}

	public void Add(TDelegate callback, int capacityIncrement = 5) { }

	public void Clear() { }

	public int get_Length() { }

	public TDelegate[] get_MultiDelegates() { }

	public TDelegate get_SingleDelegate() { }

	public void LockForChanges() { }

	public void RemoveByMovingTail(TDelegate callback) { }

	public void UnlockForChanges() { }

}

