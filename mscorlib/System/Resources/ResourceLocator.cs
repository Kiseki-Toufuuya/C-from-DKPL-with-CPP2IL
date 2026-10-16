namespace System.Resources;

internal struct ResourceLocator
{
	internal object _value; //Field offset: 0x0
	internal int _dataPos; //Field offset: 0x4

	internal int DataPosition
	{
		internal get { } //Length: 11
	}

	internal object Value
	{
		internal get { } //Length: 10
		internal set { } //Length: 23
	}

	internal ResourceLocator(int dataPos, object value) { }

	internal static bool CanCache(ResourceTypeCode value) { }

	internal int get_DataPosition() { }

	internal object get_Value() { }

	internal void set_Value(object value) { }

}

