//Type is in global namespace

public interface ICMItemControl
{

	public void Change(int category, int id, int delta) { }

	public int GetCurrent(int category, int id) { }

	public void SetMax(int category, int id) { }

	public void SetMin(int category, int id) { }

}

