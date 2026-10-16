namespace UnityEngineInternal;

[AttributeUsage(AttributeTargets::Method (64))]
public class TypeInferenceRuleAttribute : Attribute
{
	private readonly string _rule; //Field offset: 0x8

	public TypeInferenceRuleAttribute(TypeInferenceRules rule) { }

	public TypeInferenceRuleAttribute(string rule) { }

	public virtual string ToString() { }

}

