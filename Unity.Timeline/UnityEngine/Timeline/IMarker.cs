namespace UnityEngine.Timeline;

public interface IMarker
{

	public TrackAsset parent
	{
		 get { } //Length: 0
	}

	public double time
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public TrackAsset get_parent() { }

	public double get_time() { }

	public void Initialize(TrackAsset parent) { }

	public void set_time(double value) { }

}

