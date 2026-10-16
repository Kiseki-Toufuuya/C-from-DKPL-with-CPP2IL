namespace UnityEngine.Timeline;

public interface ITimeControl
{

	public void OnControlTimeStart() { }

	public void OnControlTimeStop() { }

	public void SetTime(double time) { }

}

