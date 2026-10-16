namespace System.Diagnostics;

[ComVisible(True)]
[MonoTODO("Serialized objects are not compatible with MS.NET")]
public class StackFrame
{
	public const int OFFSET_UNKNOWN = -1; //Field offset: 0x0
	private int ilOffset; //Field offset: 0x8
	private int nativeOffset; //Field offset: 0xC
	private long methodAddress; //Field offset: 0x10
	private uint methodIndex; //Field offset: 0x18
	private MethodBase methodBase; //Field offset: 0x1C
	private string fileName; //Field offset: 0x20
	private int lineNumber; //Field offset: 0x24
	private int columnNumber; //Field offset: 0x28
	private string internalMethodName; //Field offset: 0x2C

	public StackFrame() { }

	public StackFrame(int skipFrames) { }

	public StackFrame(int skipFrames, bool fNeedFileInfo) { }

	private static bool get_frame_info(int skip, bool needFileInfo, out MethodBase method, out int iloffset, out int native_offset, out string file, out int line, out int column) { }

	public override int GetFileLineNumber() { }

	public override string GetFileName() { }

	public override int GetILOffset() { }

	internal string GetInternalMethodName() { }

	public override MethodBase GetMethod() { }

	internal long GetMethodAddress() { }

	internal uint GetMethodIndex() { }

	public override int GetNativeOffset() { }

	internal string GetSecureFileName() { }

	public virtual string ToString() { }

}

