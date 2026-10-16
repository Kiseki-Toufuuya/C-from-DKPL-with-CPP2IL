namespace XeApp.Game.Common;

public class VoicePlayerBase : SoundPlayerBase
{
	private CriAtomSource atomSource; //Field offset: 0x1C

	public virtual CriAtomSource Source
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public VoicePlayerBase() { }

	public virtual CriAtomSource get_Source() { }

	public virtual void set_Source(CriAtomSource value) { }

}

