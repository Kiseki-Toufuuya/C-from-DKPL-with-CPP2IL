namespace UnityEngine.InputSystem;

[DebuggerDisplay("Value = {Get()}")]
public class InputValue
{
	internal Nullable<CallbackContext> m_Context; //Field offset: 0x8

	public bool isPressed
	{
		 get { } //Length: 86
	}

	public InputValue() { }

	public object Get() { }

	public TValue Get() { }

	public bool get_isPressed() { }

}

