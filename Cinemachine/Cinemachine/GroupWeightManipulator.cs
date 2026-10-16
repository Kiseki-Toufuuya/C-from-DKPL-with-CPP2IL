namespace Cinemachine;

[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.9/api/Cinemachine.GroupWeightManipulator.html")]
[RequireComponent(typeof(CinemachineTargetGroup))]
public class GroupWeightManipulator : MonoBehaviour
{
	[Tooltip("The weight of the group member at index 0")]
	public float m_Weight0; //Field offset: 0x10
	[Tooltip("The weight of the group member at index 1")]
	public float m_Weight1; //Field offset: 0x14
	[Tooltip("The weight of the group member at index 2")]
	public float m_Weight2; //Field offset: 0x18
	[Tooltip("The weight of the group member at index 3")]
	public float m_Weight3; //Field offset: 0x1C
	[Tooltip("The weight of the group member at index 4")]
	public float m_Weight4; //Field offset: 0x20
	[Tooltip("The weight of the group member at index 5")]
	public float m_Weight5; //Field offset: 0x24
	[Tooltip("The weight of the group member at index 6")]
	public float m_Weight6; //Field offset: 0x28
	[Tooltip("The weight of the group member at index 7")]
	public float m_Weight7; //Field offset: 0x2C
	private CinemachineTargetGroup m_group; //Field offset: 0x30

	public GroupWeightManipulator() { }

	private void OnValidate() { }

	private void Start() { }

	private void Update() { }

	private void UpdateWeights() { }

}

