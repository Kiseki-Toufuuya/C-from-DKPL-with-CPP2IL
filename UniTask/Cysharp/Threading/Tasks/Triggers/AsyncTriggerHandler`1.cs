namespace Cysharp.Threading.Tasks.Triggers;

public sealed class AsyncTriggerHandler : IAsyncOneShotTrigger, IUniTaskSource<T>, IUniTaskSource, ITriggerHandler<T>, IDisposable, IAsyncFixedUpdateHandler, IAsyncLateUpdateHandler, IAsyncOnAnimatorIKHandler, IAsyncOnAnimatorMoveHandler, IAsyncOnApplicationFocusHandler, IAsyncOnApplicationPauseHandler, IAsyncOnApplicationQuitHandler, IAsyncOnAudioFilterReadHandler, IAsyncOnBecameInvisibleHandler, IAsyncOnBecameVisibleHandler, IAsyncOnBeforeTransformParentChangedHandler, IAsyncOnCanvasGroupChangedHandler, IAsyncOnCollisionEnterHandler, IAsyncOnCollisionEnter2DHandler, IAsyncOnCollisionExitHandler, IAsyncOnCollisionExit2DHandler, IAsyncOnCollisionStayHandler, IAsyncOnCollisionStay2DHandler, IAsyncOnControllerColliderHitHandler, IAsyncOnDisableHandler, IAsyncOnDrawGizmosHandler, IAsyncOnDrawGizmosSelectedHandler, IAsyncOnEnableHandler, IAsyncOnGUIHandler, IAsyncOnJointBreakHandler, IAsyncOnJointBreak2DHandler, IAsyncOnMouseDownHandler, IAsyncOnMouseDragHandler, IAsyncOnMouseEnterHandler, IAsyncOnMouseExitHandler, IAsyncOnMouseOverHandler, IAsyncOnMouseUpHandler, IAsyncOnMouseUpAsButtonHandler, IAsyncOnParticleCollisionHandler, IAsyncOnParticleSystemStoppedHandler, IAsyncOnParticleTriggerHandler, IAsyncOnParticleUpdateJobScheduledHandler, IAsyncOnPostRenderHandler, IAsyncOnPreCullHandler, IAsyncOnPreRenderHandler, IAsyncOnRectTransformDimensionsChangeHandler, IAsyncOnRectTransformRemovedHandler, IAsyncOnRenderImageHandler, IAsyncOnRenderObjectHandler, IAsyncOnServerInitializedHandler, IAsyncOnTransformChildrenChangedHandler, IAsyncOnTransformParentChangedHandler, IAsyncOnTriggerEnterHandler, IAsyncOnTriggerEnter2DHandler, IAsyncOnTriggerExitHandler, IAsyncOnTriggerExit2DHandler, IAsyncOnTriggerStayHandler, IAsyncOnTriggerStay2DHandler, IAsyncOnValidateHandler, IAsyncOnWillRenderObjectHandler, IAsyncResetHandler, IAsyncUpdateHandler, IAsyncOnBeginDragHandler, IAsyncOnCancelHandler, IAsyncOnDeselectHandler, IAsyncOnDragHandler, IAsyncOnDropHandler, IAsyncOnEndDragHandler, IAsyncOnInitializePotentialDragHandler, IAsyncOnMoveHandler, IAsyncOnPointerClickHandler, IAsyncOnPointerDownHandler, IAsyncOnPointerEnterHandler, IAsyncOnPointerExitHandler, IAsyncOnPointerUpHandler, IAsyncOnScrollHandler, IAsyncOnSelectHandler, IAsyncOnSubmitHandler, IAsyncOnUpdateSelectedHandler
{
	private static Action<Object> cancellationCallback; //Field offset: 0x0
	private readonly AsyncTriggerBase<T> trigger; //Field offset: 0x0
	private CancellationToken cancellationToken; //Field offset: 0x0
	private CancellationTokenRegistration registration; //Field offset: 0x0
	private bool isDisposed; //Field offset: 0x0
	private bool callOnce; //Field offset: 0x0
	private UniTaskCompletionSourceCore<T> core; //Field offset: 0x0
	[CompilerGenerated]
	private ITriggerHandler<T> <Cysharp.Threading.Tasks.ITriggerHandler<T>.Prev>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private ITriggerHandler<T> <Cysharp.Threading.Tasks.ITriggerHandler<T>.Next>k__BackingField; //Field offset: 0x0

	private override ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.Next
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	private override ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.Prev
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	private static AsyncTriggerHandler`1() { }

	internal AsyncTriggerHandler`1(AsyncTriggerBase<T> trigger, bool callOnce) { }

	internal AsyncTriggerHandler`1(AsyncTriggerBase<T> trigger, CancellationToken cancellationToken, bool callOnce) { }

	private static void CancellationCallback(object state) { }

	[CompilerGenerated]
	private override ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Next() { }

	[CompilerGenerated]
	private override ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Prev() { }

	private override void Cysharp.Threading.Tasks.ITriggerHandler<T>.OnCompleted() { }

	private override void Cysharp.Threading.Tasks.ITriggerHandler<T>.OnNext(T value) { }

	[CompilerGenerated]
	private override void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Next(ITriggerHandler<T> value) { }

	[CompilerGenerated]
	private override void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Prev(ITriggerHandler<T> value) { }

	private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

	private override UniTaskStatus Cysharp.Threading.Tasks.IUniTaskSource.GetStatus(short token) { }

	private override void Cysharp.Threading.Tasks.IUniTaskSource.OnCompleted(Action<Object> continuation, object state, short token) { }

	private override UniTaskStatus Cysharp.Threading.Tasks.IUniTaskSource.UnsafeGetStatus() { }

	private override T Cysharp.Threading.Tasks.IUniTaskSource<T>.GetResult(short token) { }

	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncFixedUpdateHandler.FixedUpdateAsync() { }

	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncLateUpdateHandler.LateUpdateAsync() { }

	private override UniTask<Int32> Cysharp.Threading.Tasks.Triggers.IAsyncOnAnimatorIKHandler.OnAnimatorIKAsync() { }

	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnAnimatorMoveHandler.OnAnimatorMoveAsync() { }

	private override UniTask<Boolean> Cysharp.Threading.Tasks.Triggers.IAsyncOnApplicationFocusHandler.OnApplicationFocusAsync() { }

	private override UniTask<Boolean> Cysharp.Threading.Tasks.Triggers.IAsyncOnApplicationPauseHandler.OnApplicationPauseAsync() { }

	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnApplicationQuitHandler.OnApplicationQuitAsync() { }

	private override UniTask<ValueTuple`2<Single[], Int32>> Cysharp.Threading.Tasks.Triggers.IAsyncOnAudioFilterReadHandler.OnAudioFilterReadAsync() { }

	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnBecameInvisibleHandler.OnBecameInvisibleAsync() { }

	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnBecameVisibleHandler.OnBecameVisibleAsync() { }

	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnBeforeTransformParentChangedHandler.OnBeforeTransformParentChangedAsync() { }

	private override UniTask<PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnBeginDragHandler.OnBeginDragAsync() { }

	private override UniTask<BaseEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnCancelHandler.OnCancelAsync() { }

	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnCanvasGroupChangedHandler.OnCanvasGroupChangedAsync() { }

	private override UniTask<Collision2D> Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionEnter2DHandler.OnCollisionEnter2DAsync() { }

	private override UniTask<Collision> Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionEnterHandler.OnCollisionEnterAsync() { }

	private override UniTask<Collision2D> Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionExit2DHandler.OnCollisionExit2DAsync() { }

	private override UniTask<Collision> Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionExitHandler.OnCollisionExitAsync() { }

	private override UniTask<Collision2D> Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionStay2DHandler.OnCollisionStay2DAsync() { }

	private override UniTask<Collision> Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionStayHandler.OnCollisionStayAsync() { }

	private override UniTask<ControllerColliderHit> Cysharp.Threading.Tasks.Triggers.IAsyncOnControllerColliderHitHandler.OnControllerColliderHitAsync() { }

	private override UniTask<BaseEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnDeselectHandler.OnDeselectAsync() { }

	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnDisableHandler.OnDisableAsync() { }

	private override UniTask<PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnDragHandler.OnDragAsync() { }

	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnDrawGizmosHandler.OnDrawGizmosAsync() { }

	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnDrawGizmosSelectedHandler.OnDrawGizmosSelectedAsync() { }

	private override UniTask<PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnDropHandler.OnDropAsync() { }

	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnEnableHandler.OnEnableAsync() { }

	private override UniTask<PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnEndDragHandler.OnEndDragAsync() { }

	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOneShotTrigger.OneShotAsync() { }

	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnGUIHandler.OnGUIAsync() { }

	private override UniTask<PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnInitializePotentialDragHandler.OnInitializePotentialDragAsync() { }

	private override UniTask<Joint2D> Cysharp.Threading.Tasks.Triggers.IAsyncOnJointBreak2DHandler.OnJointBreak2DAsync() { }

	private override UniTask<Single> Cysharp.Threading.Tasks.Triggers.IAsyncOnJointBreakHandler.OnJointBreakAsync() { }

	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnMouseDownHandler.OnMouseDownAsync() { }

	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnMouseDragHandler.OnMouseDragAsync() { }

	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnMouseEnterHandler.OnMouseEnterAsync() { }

	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnMouseExitHandler.OnMouseExitAsync() { }

	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnMouseOverHandler.OnMouseOverAsync() { }

	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnMouseUpAsButtonHandler.OnMouseUpAsButtonAsync() { }

	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnMouseUpHandler.OnMouseUpAsync() { }

	private override UniTask<AxisEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnMoveHandler.OnMoveAsync() { }

	private override UniTask<GameObject> Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleCollisionHandler.OnParticleCollisionAsync() { }

	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleSystemStoppedHandler.OnParticleSystemStoppedAsync() { }

	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleTriggerHandler.OnParticleTriggerAsync() { }

	private override UniTask<ParticleSystemJobData> Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleUpdateJobScheduledHandler.OnParticleUpdateJobScheduledAsync() { }

	private override UniTask<PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerClickHandler.OnPointerClickAsync() { }

	private override UniTask<PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerDownHandler.OnPointerDownAsync() { }

	private override UniTask<PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerEnterHandler.OnPointerEnterAsync() { }

	private override UniTask<PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerExitHandler.OnPointerExitAsync() { }

	private override UniTask<PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerUpHandler.OnPointerUpAsync() { }

	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnPostRenderHandler.OnPostRenderAsync() { }

	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnPreCullHandler.OnPreCullAsync() { }

	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnPreRenderHandler.OnPreRenderAsync() { }

	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnRectTransformDimensionsChangeHandler.OnRectTransformDimensionsChangeAsync() { }

	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnRectTransformRemovedHandler.OnRectTransformRemovedAsync() { }

	private override UniTask<ValueTuple`2<RenderTexture, RenderTexture>> Cysharp.Threading.Tasks.Triggers.IAsyncOnRenderImageHandler.OnRenderImageAsync() { }

	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnRenderObjectHandler.OnRenderObjectAsync() { }

	private override UniTask<PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnScrollHandler.OnScrollAsync() { }

	private override UniTask<BaseEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnSelectHandler.OnSelectAsync() { }

	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnServerInitializedHandler.OnServerInitializedAsync() { }

	private override UniTask<BaseEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnSubmitHandler.OnSubmitAsync() { }

	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnTransformChildrenChangedHandler.OnTransformChildrenChangedAsync() { }

	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnTransformParentChangedHandler.OnTransformParentChangedAsync() { }

	private override UniTask<Collider2D> Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerEnter2DHandler.OnTriggerEnter2DAsync() { }

	private override UniTask<Collider> Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerEnterHandler.OnTriggerEnterAsync() { }

	private override UniTask<Collider2D> Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerExit2DHandler.OnTriggerExit2DAsync() { }

	private override UniTask<Collider> Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerExitHandler.OnTriggerExitAsync() { }

	private override UniTask<Collider2D> Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerStay2DHandler.OnTriggerStay2DAsync() { }

	private override UniTask<Collider> Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerStayHandler.OnTriggerStayAsync() { }

	private override UniTask<BaseEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnUpdateSelectedHandler.OnUpdateSelectedAsync() { }

	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnValidateHandler.OnValidateAsync() { }

	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnWillRenderObjectHandler.OnWillRenderObjectAsync() { }

	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncResetHandler.ResetAsync() { }

	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncUpdateHandler.UpdateAsync() { }

	public override void Dispose() { }

}

