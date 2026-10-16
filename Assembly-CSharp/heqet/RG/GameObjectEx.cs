namespace Heqet.RG;

[Extension]
public static class GameObjectEx
{

	[Extension]
	public static GameObject Find(GameObject self, string name) { }

	[Extension]
	public static void FlipActive(GameObject self) { }

	[Extension]
	public static T GetComponent(GameObject self, string name) { }

	[Extension]
	public static RectTransform GetRectTransform(GameObject self) { }

	[Extension]
	public static void SetActiveInChildren(GameObject self, bool state) { }

}

