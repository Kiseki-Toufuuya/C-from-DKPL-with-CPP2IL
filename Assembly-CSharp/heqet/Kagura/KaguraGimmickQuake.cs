namespace Heqet.Kagura;

public class KaguraGimmickQuake : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static TweenCallback <>9__15_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <Update>b__15_0() { }

	}

	private Camera gameCamera; //Field offset: 0x10
	private Camera backCamera; //Field offset: 0x14
	private Camera touchCamera; //Field offset: 0x18
	private Vector3 defaultBackCameraPosition; //Field offset: 0x1C
	private Vector3 defaultTouchCameraPosition; //Field offset: 0x28
	private Tweener tweener; //Field offset: 0x34
	private Tweener backCameraTweener; //Field offset: 0x38
	private Tweener touchCameraTweener; //Field offset: 0x3C
	private float timer; //Field offset: 0x40
	private bool initialized; //Field offset: 0x44
	private bool isPause; //Field offset: 0x45

	public KaguraGimmickQuake() { }

	[CompilerGenerated]
	private void <Update>b__15_1() { }

	[CompilerGenerated]
	private void <Update>b__15_2() { }

	public void Initialize() { }

	private void ResetBackCamera() { }

	private void ResetTouchCamera() { }

	public void Terminate() { }

	public void Update() { }

}

