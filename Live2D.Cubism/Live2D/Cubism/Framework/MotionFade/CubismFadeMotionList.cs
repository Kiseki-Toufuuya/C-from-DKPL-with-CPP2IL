namespace Live2D.Cubism.Framework.MotionFade;

[CreateAssetMenu(menuName = "Live2D Cubism/Fade Motion List")]
public class CubismFadeMotionList : ScriptableObject
{
	[SerializeField]
	public Int32[] MotionInstanceIds; //Field offset: 0xC
	[SerializeField]
	public CubismFadeMotionData[] CubismFadeMotionObjects; //Field offset: 0x10

	public CubismFadeMotionList() { }

}

