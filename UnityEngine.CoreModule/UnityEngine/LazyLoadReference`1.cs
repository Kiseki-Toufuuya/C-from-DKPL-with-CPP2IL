namespace UnityEngine;

public struct LazyLoadReference
{
	private const int kInstanceID_None = 0; //Field offset: 0x0
	[SerializeField]
	private int m_InstanceID; //Field offset: 0x0

	public T asset
	{
		 get { } //Length: 166
		 set { } //Length: 203
	}

	public bool isSet
	{
		 get { } //Length: 14
	}

	public T get_asset() { }

	public bool get_isSet() { }

	public static LazyLoadReference<T> op_Implicit(T asset) { }

	public void set_asset(T value) { }

}

