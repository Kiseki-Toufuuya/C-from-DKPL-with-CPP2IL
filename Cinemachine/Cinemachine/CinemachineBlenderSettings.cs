namespace Cinemachine;

[DocumentationSorting(Level::UserRef (2))]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.9/manual/CinemachineBlending.html")]
public sealed class CinemachineBlenderSettings : ScriptableObject
{
	[DocumentationSorting(Level::UserRef (2))]
	internal struct CustomBlend
	{
		[Tooltip("When blending from this camera")]
		public string m_From; //Field offset: 0x0
		[Tooltip("When blending to this camera")]
		public string m_To; //Field offset: 0x4
		[CinemachineBlendDefinitionProperty]
		[Tooltip("Blend curve definition")]
		public CinemachineBlendDefinition m_Blend; //Field offset: 0x8

	}

	public const string kBlendFromAnyCameraLabel = "**ANY CAMERA**"; //Field offset: 0x0
	[Tooltip("The array containing explicitly defined blends between two Virtual Cameras")]
	public CustomBlend[] m_CustomBlends; //Field offset: 0xC

	public CinemachineBlenderSettings() { }

	public CinemachineBlendDefinition GetBlendForVirtualCameras(string fromCameraName, string toCameraName, CinemachineBlendDefinition defaultBlend) { }

}

