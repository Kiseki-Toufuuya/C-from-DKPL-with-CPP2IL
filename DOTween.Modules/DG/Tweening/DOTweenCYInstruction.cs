namespace DG.Tweening;

public static class DOTweenCYInstruction
{
	internal class WaitForCompletion : CustomYieldInstruction
	{
		private readonly Tween t; //Field offset: 0x8

		public virtual bool keepWaiting
		{
			 get { } //Length: 46
		}

		public WaitForCompletion(Tween tween) { }

		public virtual bool get_keepWaiting() { }

	}

	internal class WaitForElapsedLoops : CustomYieldInstruction
	{
		private readonly Tween t; //Field offset: 0x8
		private readonly int elapsedLoops; //Field offset: 0xC

		public virtual bool keepWaiting
		{
			 get { } //Length: 53
		}

		public WaitForElapsedLoops(Tween tween, int elapsedLoops) { }

		public virtual bool get_keepWaiting() { }

	}

	internal class WaitForKill : CustomYieldInstruction
	{
		private readonly Tween t; //Field offset: 0x8

		public virtual bool keepWaiting
		{
			 get { } //Length: 26
		}

		public WaitForKill(Tween tween) { }

		public virtual bool get_keepWaiting() { }

	}

	internal class WaitForPosition : CustomYieldInstruction
	{
		private readonly Tween t; //Field offset: 0x8
		private readonly float position; //Field offset: 0xC

		public virtual bool keepWaiting
		{
			 get { } //Length: 84
		}

		public WaitForPosition(Tween tween, float position) { }

		public virtual bool get_keepWaiting() { }

	}

	internal class WaitForRewind : CustomYieldInstruction
	{
		private readonly Tween t; //Field offset: 0x8

		public virtual bool keepWaiting
		{
			 get { } //Length: 93
		}

		public WaitForRewind(Tween tween) { }

		public virtual bool get_keepWaiting() { }

	}

	internal class WaitForStart : CustomYieldInstruction
	{
		private readonly Tween t; //Field offset: 0x8

		public virtual bool keepWaiting
		{
			 get { } //Length: 43
		}

		public WaitForStart(Tween tween) { }

		public virtual bool get_keepWaiting() { }

	}


}

