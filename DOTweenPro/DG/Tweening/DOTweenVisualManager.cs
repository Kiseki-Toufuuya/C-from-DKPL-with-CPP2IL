namespace DG.Tweening;

[AddComponentMenu(null)]
public class DOTweenVisualManager : MonoBehaviour
{
	public VisualManagerPreset preset; //Field offset: 0x10
	public OnEnableBehaviour onEnableBehaviour; //Field offset: 0x14
	public OnDisableBehaviour onDisableBehaviour; //Field offset: 0x18
	private bool _requiresRestartFromSpawnPoint; //Field offset: 0x1C
	private ABSAnimationComponent _animComponent; //Field offset: 0x20

	public DOTweenVisualManager() { }

	private void Awake() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void Update() { }

}

