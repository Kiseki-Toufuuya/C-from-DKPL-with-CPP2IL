namespace System;

[ComVisible(True)]
public class WeakReference : ISerializable
{
	private bool isLongReference; //Field offset: 0x8
	private GCHandle gcHandle; //Field offset: 0xC

	public override bool IsAlive
	{
		 get { } //Length: 33
	}

	public override object Target
	{
		 get { } //Length: 58
		 set { } //Length: 64
	}

	public override bool TrackResurrection
	{
		 get { } //Length: 11
	}

	protected WeakReference() { }

	public WeakReference(object target) { }

	public WeakReference(object target, bool trackResurrection) { }

	protected WeakReference(SerializationInfo info, StreamingContext context) { }

	private void AllocateHandle(object target) { }

	protected virtual void Finalize() { }

	public override bool get_IsAlive() { }

	public override object get_Target() { }

	public override bool get_TrackResurrection() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public override void set_Target(object value) { }

}

