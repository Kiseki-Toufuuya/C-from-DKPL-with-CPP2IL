namespace System.ComponentModel;

public class PropertyChangingEventArgs : EventArgs
{
	private readonly string _propertyName; //Field offset: 0x8

	public PropertyChangingEventArgs(string propertyName) { }

}

