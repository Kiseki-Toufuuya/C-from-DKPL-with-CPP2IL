namespace UnityEngine;

[RequiredByNativeCode]
public struct Keyframe
{
	private float m_Time; //Field offset: 0x0
	private float m_Value; //Field offset: 0x4
	private float m_InTangent; //Field offset: 0x8
	private float m_OutTangent; //Field offset: 0xC
	private int m_WeightedMode; //Field offset: 0x10
	private float m_InWeight; //Field offset: 0x14
	private float m_OutWeight; //Field offset: 0x18

	public float inTangent
	{
		 get { } //Length: 11
		 set { } //Length: 18
	}

	public float outTangent
	{
		 set { } //Length: 18
	}

	public float time
	{
		 get { } //Length: 10
		 set { } //Length: 17
	}

	public float value
	{
		 get { } //Length: 11
		 set { } //Length: 18
	}

	public Keyframe(float time, float value) { }

	public Keyframe(float time, float value, float inTangent, float outTangent) { }

	public float get_inTangent() { }

	public float get_time() { }

	public float get_value() { }

	public void set_inTangent(float value) { }

	public void set_outTangent(float value) { }

	public void set_time(float value) { }

	public void set_value(float value) { }

}

