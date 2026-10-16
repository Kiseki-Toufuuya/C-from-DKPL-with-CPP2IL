namespace XeApp.Game;

public class AutoSceneTransition
{
	internal class AfterEpisodeManager
	{
		internal enum eType
		{
			None = 0,
			World = 1,
			Spot = 2,
		}

		private eType m_Type; //Field offset: 0x8
		private int m_AfterEpisodeId; //Field offset: 0xC

		public int after_ep_id
		{
			 get { } //Length: 11
			 set { } //Length: 14
		}

		public eType type
		{
			 get { } //Length: 11
		}

		public AfterEpisodeManager() { }

		public void Clear() { }

		public int get_after_ep_id() { }

		public eType get_type() { }

		public bool IsAfterEpisode() { }

		public void set_after_ep_id(int value) { }

		public void SetWorldEpisode() { }

	}

	internal class DirectSpot
	{
		internal enum Type
		{
			Select = 0,
			Reconstructing = 1,
			Repairing = 2,
			None = 3,
		}

		public Type m_type; //Field offset: 0x8
		public bool m_isDirectEnter; //Field offset: 0xC

		public DirectSpot() { }

		public void ClearDirectTransitionSpot() { }

		public bool IsDirectTransitionSpot() { }

		public void SetTransitionType(Type type, bool isDirectEnter = false) { }

	}

	internal class MusicSelectInSpot
	{
		private enum State
		{
			None = 0,
			MusicSelectInSpot = 1,
			ReturnToSpot = 2,
		}

		private State m_state; //Field offset: 0x8

		public bool IsReturnToSpot
		{
			 get { } //Length: 15
		}

		public MusicSelectInSpot() { }

		public void BackupTransition() { }

		public void Clear() { }

		public bool get_IsReturnToSpot() { }

		public void SetMusicSelect() { }

	}

	internal enum TransitionSceneType
	{
		None = 0,
		Home = 1,
		World = 2,
		Spot = 3,
		Event = 4,
	}

	private static AutoSceneTransition m_Instance; //Field offset: 0x0
	public TransitionSceneType m_transType; //Field offset: 0x8
	public DirectSpot m_directSpot; //Field offset: 0xC
	public AfterEpisodeManager m_afterEpisodeManager; //Field offset: 0x10
	public MusicSelectInSpot m_musicSelectInSpot; //Field offset: 0x14

	public static AutoSceneTransition Instance
	{
		 get { } //Length: 40
	}

	public AutoSceneTransition() { }

	public static void Clear() { }

	public void Create() { }

	public static AutoSceneTransition get_Instance() { }

	public void TransitionScene() { }

}

