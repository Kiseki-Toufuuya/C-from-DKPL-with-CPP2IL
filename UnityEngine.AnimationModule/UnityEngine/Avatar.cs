namespace UnityEngine;

[NativeHeader("Modules/Animation/Avatar.h")]
[UsedByNativeCode]
public class Avatar : object
{

	public HumanDescription humanDescription
	{
		 get { } //Length: 119
	}

	public bool isHuman
	{
		[NativeMethod("IsHuman")]
		 get { } //Length: 98
	}

	public bool isValid
	{
		[NativeMethod("IsValid")]
		 get { } //Length: 98
	}

	private Avatar() { }

	public HumanDescription get_humanDescription() { }

	private static void get_humanDescription_Injected(IntPtr _unity_self, out HumanDescription ret) { }

	[NativeMethod("IsHuman")]
	public bool get_isHuman() { }

	private static bool get_isHuman_Injected(IntPtr _unity_self) { }

	[NativeMethod("IsValid")]
	public bool get_isValid() { }

	private static bool get_isValid_Injected(IntPtr _unity_self) { }

	internal float GetAxisLength(int humanId) { }

	internal Vector3 GetLimitSign(int humanId) { }

	internal Quaternion GetPostRotation(int humanId) { }

	internal Quaternion GetPreRotation(int humanId) { }

	internal Quaternion GetZYPostQ(int humanId, Quaternion parentQ, Quaternion q) { }

	internal Quaternion GetZYRoll(int humanId, Vector3 uvw) { }

	[NativeMethod("GetAxisLength")]
	internal float Internal_GetAxisLength(int humanId) { }

	private static float Internal_GetAxisLength_Injected(IntPtr _unity_self, int humanId) { }

	[NativeMethod("GetLimitSign")]
	internal Vector3 Internal_GetLimitSign(int humanId) { }

	private static void Internal_GetLimitSign_Injected(IntPtr _unity_self, int humanId, out Vector3 ret) { }

	[NativeMethod("GetPostRotation")]
	internal Quaternion Internal_GetPostRotation(int humanId) { }

	private static void Internal_GetPostRotation_Injected(IntPtr _unity_self, int humanId, out Quaternion ret) { }

	[NativeMethod("GetPreRotation")]
	internal Quaternion Internal_GetPreRotation(int humanId) { }

	private static void Internal_GetPreRotation_Injected(IntPtr _unity_self, int humanId, out Quaternion ret) { }

	[NativeMethod("GetZYPostQ")]
	internal Quaternion Internal_GetZYPostQ(int humanId, Quaternion parentQ, Quaternion q) { }

	private static void Internal_GetZYPostQ_Injected(IntPtr _unity_self, int humanId, in Quaternion parentQ, in Quaternion q, out Quaternion ret) { }

	[NativeMethod("GetZYRoll")]
	internal Quaternion Internal_GetZYRoll(int humanId, Vector3 uvw) { }

	private static void Internal_GetZYRoll_Injected(IntPtr _unity_self, int humanId, in Vector3 uvw, out Quaternion ret) { }

	internal void SetMuscleMinMax(int muscleId, float min, float max) { }

	private static void SetMuscleMinMax_Injected(IntPtr _unity_self, int muscleId, float min, float max) { }

	internal void SetParameter(int parameterId, float value) { }

	private static void SetParameter_Injected(IntPtr _unity_self, int parameterId, float value) { }

}

