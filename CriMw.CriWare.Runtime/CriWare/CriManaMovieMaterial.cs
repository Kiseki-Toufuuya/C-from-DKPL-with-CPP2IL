namespace CriWare;

[AddComponentMenu("CRIWARE/CriManaMovieMaterial")]
public class CriManaMovieMaterial : CriManaMovieMaterialBase
{
	[SerializeField]
	private string _moviePath; //Field offset: 0x50
	[SerializeField]
	private bool _loop; //Field offset: 0x54
	[SerializeField]
	private bool _audioBaseConcatenation; //Field offset: 0x55
	[SerializeField]
	private bool _additiveMode; //Field offset: 0x56
	[SerializeField]
	private bool _advancedAudio; //Field offset: 0x57
	[SerializeField]
	private bool _ambisonics; //Field offset: 0x58
	[SerializeField]
	private bool _applyTargetAlpha; //Field offset: 0x59
	[SerializeField]
	private bool _uiRenderMode; //Field offset: 0x5A
	private GameObject ambisonicSource; //Field offset: 0x5C

	public bool additiveMode
	{
		 get { } //Length: 11
		 set { } //Length: 97
	}

	public bool advancedAudio
	{
		 get { } //Length: 11
		 set { } //Length: 119
	}

	public bool ambisonics
	{
		 get { } //Length: 11
		 set { } //Length: 1023
	}

	public bool applyTargetAlpha
	{
		 get { } //Length: 11
		 set { } //Length: 97
	}

	public bool audioBaseConcatenation
	{
		 get { } //Length: 11
		 set { } //Length: 97
	}

	protected virtual uint FilePathLength
	{
		 get { } //Length: 107
	}

	protected virtual bool initializeWithAdvancedAudio
	{
		 get { } //Length: 11
	}

	protected virtual bool initializeWithAmbisonics
	{
		 get { } //Length: 11
	}

	public bool loop
	{
		 get { } //Length: 11
		 set { } //Length: 97
	}

	public string moviePath
	{
		 get { } //Length: 11
		 set { } //Length: 110
	}

	public bool uiRenderMode
	{
		 get { } //Length: 11
		 set { } //Length: 97
	}

	public CriManaMovieMaterial() { }

	public bool get_additiveMode() { }

	public bool get_advancedAudio() { }

	public bool get_ambisonics() { }

	public bool get_applyTargetAlpha() { }

	public bool get_audioBaseConcatenation() { }

	protected virtual uint get_FilePathLength() { }

	protected virtual bool get_initializeWithAdvancedAudio() { }

	protected virtual bool get_initializeWithAmbisonics() { }

	public bool get_loop() { }

	public string get_moviePath() { }

	public bool get_uiRenderMode() { }

	public void set_additiveMode(bool value) { }

	public void set_advancedAudio(bool value) { }

	public void set_ambisonics(bool value) { }

	public void set_applyTargetAlpha(bool value) { }

	public void set_audioBaseConcatenation(bool value) { }

	public void set_loop(bool value) { }

	public void set_moviePath(string value) { }

	public void set_uiRenderMode(bool value) { }

	protected virtual void SetDataToPlayer() { }

}

