namespace XeApp.Game;

public sealed class OnActiveContentCallback : MulticastDelegate
{

	public OnActiveContentCallback(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(CMContentList contentList, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(CMContentList contentList) { }

}

