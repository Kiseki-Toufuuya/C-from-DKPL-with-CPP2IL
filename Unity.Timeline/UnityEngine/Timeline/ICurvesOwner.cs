namespace UnityEngine.Timeline;

internal interface ICurvesOwner
{

	public object asset
	{
		 get { } //Length: 0
	}

	public object assetOwner
	{
		 get { } //Length: 0
	}

	public AnimationClip curves
	{
		 get { } //Length: 0
	}

	public string defaultCurvesName
	{
		 get { } //Length: 0
	}

	public double duration
	{
		 get { } //Length: 0
	}

	public bool hasCurves
	{
		 get { } //Length: 0
	}

	public TrackAsset targetTrack
	{
		 get { } //Length: 0
	}

	public void CreateCurves(string curvesClipName) { }

	public object get_asset() { }

	public object get_assetOwner() { }

	public AnimationClip get_curves() { }

	public string get_defaultCurvesName() { }

	public double get_duration() { }

	public bool get_hasCurves() { }

	public TrackAsset get_targetTrack() { }

}

