namespace UnityEngine.Timeline;

public interface IPropertyCollector
{

	public void AddFromClip(AnimationClip clip) { }

	public void AddFromClip(GameObject obj, AnimationClip clip) { }

	public void AddFromClips(IEnumerable<AnimationClip> clips) { }

	public void AddFromClips(GameObject obj, IEnumerable<AnimationClip> clips) { }

	public void AddFromComponent(GameObject obj, Component component) { }

	public void AddFromName(string name) { }

	public void AddFromName(string name) { }

	public void AddFromName(GameObject obj, string name) { }

	public void AddFromName(GameObject obj, string name) { }

	public void AddFromName(Component component, string name) { }

	public void AddObjectProperties(object obj, AnimationClip clip) { }

	public void PopActiveGameObject() { }

	public void PushActiveGameObject(GameObject gameObject) { }

}

