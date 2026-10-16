namespace System;

internal sealed class LocalDataStoreElement
{
	private object m_value; //Field offset: 0x8
	private long m_cookie; //Field offset: 0x10

	public long Cookie
	{
		 get { } //Length: 14
	}

	public object Value
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public LocalDataStoreElement(long cookie) { }

	public long get_Cookie() { }

	public object get_Value() { }

	public void set_Value(object value) { }

}

