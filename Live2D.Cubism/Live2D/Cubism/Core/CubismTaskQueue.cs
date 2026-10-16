namespace Live2D.Cubism.Core;

public static class CubismTaskQueue
{
	internal sealed class CubismTaskHandler : MulticastDelegate
	{

		public CubismTaskHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ICubismTask task, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(ICubismTask task) { }

	}

	public static CubismTaskHandler OnTask; //Field offset: 0x0

	internal static void Enqueue(ICubismTask task) { }

}

