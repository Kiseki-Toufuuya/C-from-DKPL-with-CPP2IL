namespace UnityEngine.UIElements;

public class RadioButtonGroup : BaseField<Int32>, IGroupBox
{
	[CompilerGenerated]
	private sealed class <get_choices>d__17 : IEnumerable<String>, IEnumerable, IEnumerator<String>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private string <>2__current; //Field offset: 0xC
		private int <>l__initialThreadId; //Field offset: 0x10
		public RadioButtonGroup <>4__this; //Field offset: 0x14
		private PooledObject<List`1<RadioButton>> <_>5__1; //Field offset: 0x18
		private List<RadioButton> <radioButtons>5__2; //Field offset: 0x20
		private Enumerator<RadioButton> <>s__3; //Field offset: 0x24
		private RadioButton <button>5__4; //Field offset: 0x34

		private override string System.Collections.Generic.IEnumerator<System.String>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		[DebuggerHidden]
		public <get_choices>d__17(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<String> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

		[DebuggerHidden]
		private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlFactory : UxmlFactory<RadioButtonGroup, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlTraits : BaseFieldTraits<Int32, UxmlIntAttributeDescription>
	{
		private UxmlStringAttributeDescription m_Choices; //Field offset: 0x50

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	internal static readonly BindingId choicesProperty; //Field offset: 0x0
	public static readonly string ussClassName; //Field offset: 0x4C
	public static readonly string containerUssClassName; //Field offset: 0x50
	internal static readonly string containerName; //Field offset: 0x54
	internal static readonly string choicesContainerName; //Field offset: 0x58
	private VisualElement m_ChoiceRadioButtonContainer; //Field offset: 0x3B8
	private VisualElement m_ContentContainer; //Field offset: 0x3BC
	private UQueryBuilder<RadioButton> m_GetAllRadioButtonsQuery; //Field offset: 0x3C0
	private readonly List<RadioButton> m_RegisteredRadioButtons; //Field offset: 0x3DC
	private RadioButton m_SelectedRadioButton; //Field offset: 0x3E0
	private EventCallback<ChangeEvent`1<Boolean>> m_RadioButtonValueChangedCallback; //Field offset: 0x3E4
	private bool m_UpdatingButtons; //Field offset: 0x3E8
	private List<String> m_Choices; //Field offset: 0x3EC

	[CreateProperty]
	public IEnumerable<String> choices
	{
		[IteratorStateMachine(typeof(<get_choices>d__17))]
		 get { } //Length: 95
		 set { } //Length: 278
	}

	internal List<String> choicesList
	{
		internal set { } //Length: 16
	}

	public virtual VisualElement contentContainer
	{
		 get { } //Length: 19
	}

	private static RadioButtonGroup() { }

	public RadioButtonGroup(string label, List<String> radioButtonChoices = null) { }

	public RadioButtonGroup() { }

	[CompilerGenerated]
	private void <ScheduleRadioButtons>b__31_0() { }

	[CompilerGenerated]
	internal static bool <set_choices>g__AreListEqual|18_0(List<String> list1, IEnumerable<String> list2) { }

	[IteratorStateMachine(typeof(<get_choices>d__17))]
	public IEnumerable<String> get_choices() { }

	public virtual VisualElement get_contentContainer() { }

	private void GetAllRadioButtons(List<RadioButton> radioButtons) { }

	private void RadioButtonValueChangedCallback(ChangeEvent<Boolean> evt) { }

	private void RebuildRadioButtonsFromChoices() { }

	private void RegisterRadioButton(RadioButton radioButton) { }

	private void ScheduleRadioButtons() { }

	public void set_choices(IEnumerable<String> value) { }

	internal void set_choicesList(List<String> value) { }

	public virtual void SetValueWithoutNotify(int newValue) { }

	private override void UnityEngine.UIElements.IGroupBox.OnOptionAdded(IGroupBoxOption option) { }

	private override void UnityEngine.UIElements.IGroupBox.OnOptionRemoved(IGroupBoxOption option) { }

	private void UnregisterRadioButton(RadioButton radioButton) { }

	private void UpdateRadioButtons(bool notify) { }

}

