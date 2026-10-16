namespace UnityEngine.InputSystem.UI;

[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.18/manual/UISupport.html#multiplayer-uis")]
public class MultiplayerEventSystem : EventSystem
{
	[SerializeField]
	[Tooltip("If set, only process mouse and navigation events for any game objects which are children of this game object.")]
	private GameObject m_PlayerRoot; //Field offset: 0x34

	public GameObject playerRoot
	{
		 get { } //Length: 11
		 set { } //Length: 37
	}

	public MultiplayerEventSystem() { }

	public GameObject get_playerRoot() { }

	private void InitializePlayerRoot() { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	public void set_playerRoot(GameObject value) { }

	protected virtual void Update() { }

}

