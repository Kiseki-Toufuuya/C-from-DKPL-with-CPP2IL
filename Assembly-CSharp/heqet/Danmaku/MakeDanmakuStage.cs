namespace Heqet.Danmaku;

[DefaultExecutionOrder(-10000)]
public class MakeDanmakuStage : MonoBehaviour
{
	public GameObject[] sceneObjects; //Field offset: 0x10

	public MakeDanmakuStage() { }

	private void Awake() { }

	private void SceneUnloaded(Scene thisScene) { }

}

