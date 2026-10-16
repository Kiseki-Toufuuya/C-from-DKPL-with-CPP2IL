namespace UnityEngine;

[RequiredByNativeCode]
public sealed class AnimationEvent
{
	internal float m_Time; //Field offset: 0x8
	internal string m_FunctionName; //Field offset: 0xC
	internal string m_StringParameter; //Field offset: 0x10
	internal object m_ObjectReferenceParameter; //Field offset: 0x14
	internal float m_FloatParameter; //Field offset: 0x18
	internal int m_IntParameter; //Field offset: 0x1C
	internal int m_MessageOptions; //Field offset: 0x20
	internal AnimationEventSource m_Source; //Field offset: 0x24
	internal AnimationState m_StateSender; //Field offset: 0x28
	internal AnimatorStateInfo m_AnimatorStateInfo; //Field offset: 0x2C
	internal AnimatorClipInfo m_AnimatorClipInfo; //Field offset: 0x50

	public string functionName
	{
		 get { } //Length: 11
	}

	public int intParameter
	{
		 get { } //Length: 11
	}

	public AnimationEvent() { }

	public string get_functionName() { }

	public int get_intParameter() { }

}

