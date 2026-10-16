namespace XeApp.Game;

public class LogReceiver : MonoBehaviour
{
	internal class LogDataSet
	{
		public Queue<LogRecord> LogQueue; //Field offset: 0x8
		public long Counter; //Field offset: 0x10
		public object lockObj; //Field offset: 0x18

		public LogDataSet() { }

		public void Dequeue() { }

		public void Enqueue(string logString, string stackTrace, LogType type) { }

		public void Reset() { }

	}

	internal struct LogRecord
	{
		public string Message; //Field offset: 0x0
		public string Date; //Field offset: 0x4
		public int Hash; //Field offset: 0x8

	}

	private const int Q_CAPACITY = 20; //Field offset: 0x0
	public LogDataSet AllLog; //Field offset: 0x10
	public LogDataSet ErrorLog; //Field offset: 0x14

	public LogReceiver() { }

	private void AddLog(string logString, string stackTrace, LogType type) { }

	private void Awake() { }

	private void OnDestroy() { }

	private void OnLogMessageReceived(string logString, string stackTrace, LogType type) { }

	private void OnLogMessageReceivedThread(string logString, string stackTrace, LogType type) { }

	private void OnLowMemory() { }

}

