namespace System.Runtime.Diagnostics;

internal sealed class EtwProvider : DiagnosticsEventProvider
{
	private Action invokeControllerCallback; //Field offset: 0x48
	private bool end2EndActivityTracingEnabled; //Field offset: 0x4C

	internal Action ControllerCallBack
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	internal bool IsEnd2EndActivityTracingEnabled
	{
		internal get { } //Length: 11
	}

	internal EtwProvider(Guid id) { }

	internal Action get_ControllerCallBack() { }

	internal bool get_IsEnd2EndActivityTracingEnabled() { }

	protected virtual void OnControllerCommand() { }

	internal void set_ControllerCallBack(Action value) { }

	internal void SetEnd2EndActivityTracingEnabled(bool isEnd2EndActivityTracingEnabled) { }

	internal bool WriteEvent(ref EventDescriptor eventDescriptor, EventTraceActivity eventTraceActivity, string value1, string value2) { }

	internal bool WriteEvent(ref EventDescriptor eventDescriptor, EventTraceActivity eventTraceActivity, string value1, string value2, string value3) { }

	internal bool WriteEvent(ref EventDescriptor eventDescriptor, EventTraceActivity eventTraceActivity, string value1, string value2, string value3, string value4) { }

}

