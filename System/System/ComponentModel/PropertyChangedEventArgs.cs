namespace System.ComponentModel;

public class PropertyChangedEventArgs : EventArgs
{
	private readonly string _propertyName; //Field offset: 0x8

	public PropertyChangedEventArgs(string propertyName) { }

}

