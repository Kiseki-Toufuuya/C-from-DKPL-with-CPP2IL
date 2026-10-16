namespace Heqet;

public class ChangeAnimationClip : MonoBehaviour
{
	internal class Data
	{
		public string stateName; //Field offset: 0x8
		public AnimationClip clip; //Field offset: 0xC

		public Data() { }

	}

	[SerializeField]
	private RuntimeAnimatorController overwriteController; //Field offset: 0x10
	[SerializeField]
	private List<Data> list; //Field offset: 0x14
	private Animator animator; //Field offset: 0x18
	private AnimatorOverrideController animatorOverrideController; //Field offset: 0x1C

	public ChangeAnimationClip() { }

	public void ChangeClip(string stateName, AnimationClip clip) { }

	private void Start() { }

}

