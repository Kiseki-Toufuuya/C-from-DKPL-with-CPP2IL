namespace UnityEngine;

[NativeHeader("Modules/Animation/ScriptBindings/AvatarBuilder.bindings.h")]
[NativeHeader("Modules/Animation/HumanDescription.h")]
public struct HumanDescription
{
	[NativeName("m_Human")]
	public HumanBone[] human; //Field offset: 0x0
	[NativeName("m_Skeleton")]
	public SkeletonBone[] skeleton; //Field offset: 0x4
	internal float m_ArmTwist; //Field offset: 0x8
	internal float m_ForeArmTwist; //Field offset: 0xC
	internal float m_UpperLegTwist; //Field offset: 0x10
	internal float m_LegTwist; //Field offset: 0x14
	internal float m_ArmStretch; //Field offset: 0x18
	internal float m_LegStretch; //Field offset: 0x1C
	internal float m_FeetSpacing; //Field offset: 0x20
	internal float m_GlobalScale; //Field offset: 0x24
	internal string m_RootMotionBoneName; //Field offset: 0x28
	internal bool m_HasTranslationDoF; //Field offset: 0x2C
	internal bool m_HasExtraRoot; //Field offset: 0x2D
	internal bool m_SkeletonHasParents; //Field offset: 0x2E

}

