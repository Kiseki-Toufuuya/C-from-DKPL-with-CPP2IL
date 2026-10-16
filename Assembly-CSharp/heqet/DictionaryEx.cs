namespace Heqet;

[Extension]
public static class DictionaryEx
{

	[Extension]
	public static Value Get(Dictionary<Key, Value> self, Key key, Value defaultValue) { }

	[Extension]
	public static void Set(Dictionary<Key, Value> self, Key key, Value value) { }

}

