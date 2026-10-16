namespace XeApp.Game;

public class AnimationEventEffect : MonoBehaviour
{
	public const int DEFAULT_MESSAGE_CAPACITY = 10; //Field offset: 0x0
	public Vector3 EffectPostion; //Field offset: 0x10
	public List<String> messageList; //Field offset: 0x1C
	public AtlasImage Image; //Field offset: 0x20

	public AnimationEventEffect() { }

	public void AddMessage(string message) { }

	public void ChangeSprite(string spriteName) { }

	public void ClearMessage() { }

	public void SetActiveObject(int enable) { }

	public void StartEffect(string EffectName) { }

}

