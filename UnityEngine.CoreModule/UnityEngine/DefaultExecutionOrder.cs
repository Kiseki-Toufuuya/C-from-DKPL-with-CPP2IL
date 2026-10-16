namespace UnityEngine;

[AttributeUsage(AttributeTargets::Class (4))]
[UsedByNativeCode]
public class DefaultExecutionOrder : Attribute
{
	private int m_Order; //Field offset: 0x8

	public int order
	{
		 get { } //Length: 11
	}

	public DefaultExecutionOrder(int order) { }

	public int get_order() { }

}

