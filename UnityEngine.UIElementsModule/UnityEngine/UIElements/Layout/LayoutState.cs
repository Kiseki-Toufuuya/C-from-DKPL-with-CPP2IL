namespace UnityEngine.UIElements.Layout;

internal struct LayoutState
{
	public IntPtr measureFunctionCallback; //Field offset: 0x0
	public IntPtr baselineFunctionCallback; //Field offset: 0x4
	public IntPtr unusedExceptionPointer; //Field offset: 0x8
	public uint depth; //Field offset: 0xC
	public uint currentGenerationCount; //Field offset: 0x10
	public bool error; //Field offset: 0x14

	public static LayoutState Default
	{
		 get { } //Length: 94
	}

	public static LayoutState get_Default() { }

}

