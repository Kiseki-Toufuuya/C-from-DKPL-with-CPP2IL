namespace XeApp.Game.Commandlet;

public interface ICommand
{

	public string Name
	{
		 get { } //Length: 0
	}

	public Task<Int32> Command(String[] args) { }

	public string get_Name() { }

}

