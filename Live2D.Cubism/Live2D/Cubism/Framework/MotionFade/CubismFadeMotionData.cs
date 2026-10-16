namespace Live2D.Cubism.Framework.MotionFade;

public class CubismFadeMotionData : ScriptableObject
{
	[SerializeField]
	public string MotionName; //Field offset: 0xC
	[HideInInspector]
	[SerializeField]
	public float ModelFadeInTime; //Field offset: 0x10
	[HideInInspector]
	[SerializeField]
	public float ModelFadeOutTime; //Field offset: 0x14
	[SerializeField]
	public float FadeInTime; //Field offset: 0x18
	[SerializeField]
	public float FadeOutTime; //Field offset: 0x1C
	[SerializeField]
	public String[] ParameterIds; //Field offset: 0x20
	[SerializeField]
	public AnimationCurve[] ParameterCurves; //Field offset: 0x24
	[SerializeField]
	public Single[] ParameterFadeInTimes; //Field offset: 0x28
	[SerializeField]
	public Single[] ParameterFadeOutTimes; //Field offset: 0x2C
	[SerializeField]
	public float MotionLength; //Field offset: 0x30

	public CubismFadeMotionData() { }

	public static CubismFadeMotionData CreateInstance(CubismMotion3Json motion3Json, string motionName, float motionLength, bool shouldImportAsOriginalWorkflow = false, bool isCallFromModelJson = false, CubismModel3Json model3Json = null) { }

	public static CubismFadeMotionData CreateInstance(CubismFadeMotionData fadeMotion, CubismMotion3Json motion3Json, string motionName, float motionLength, bool shouldImportAsOriginalWorkflow = false, bool isCallFormModelJson = false, CubismModel3Json model3Json = null) { }

	private static void GetFadeDataFromModel3Json(CubismModel3Json modelJson, CubismFadeMotionData fadeMotion) { }

}

