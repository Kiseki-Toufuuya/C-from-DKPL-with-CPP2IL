namespace UnityEngine.InputSystem;

public class InputActionReference : ScriptableObject
{
	[SerializeField]
	internal InputActionAsset m_Asset; //Field offset: 0xC
	[SerializeField]
	internal string m_ActionId; //Field offset: 0x10
	private InputAction m_Action; //Field offset: 0x14

	public InputAction action
	{
		 get { } //Length: 316
	}

	public InputActionAsset asset
	{
		 get { } //Length: 32
	}

	public InputActionReference() { }

	private void CheckImmutableReference() { }

	public static InputActionReference Create(InputAction action) { }

	public InputAction get_action() { }

	public InputActionAsset get_asset() { }

	private static string GetDisplayName(InputAction action) { }

	internal void Invalidate() { }

	internal static void InvalidateAll() { }

	public static InputAction op_Implicit(InputActionReference reference) { }

	public void Set(InputAction action) { }

	public void Set(InputActionAsset asset, string mapName, string actionName) { }

	private void SetInternal(InputActionAsset assetArg, InputAction actionArg) { }

	internal string ToDisplayName() { }

	public InputAction ToInputAction() { }

	public virtual string ToString() { }

}

