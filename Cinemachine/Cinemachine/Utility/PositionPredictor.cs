namespace Cinemachine.Utility;

public class PositionPredictor
{
	private Vector3 m_Velocity; //Field offset: 0x8
	private Vector3 m_SmoothDampVelocity; //Field offset: 0x14
	private Vector3 m_Pos; //Field offset: 0x20
	private bool m_HavePos; //Field offset: 0x2C
	public float Smoothing; //Field offset: 0x30

	public PositionPredictor() { }

	public void AddPosition(Vector3 pos, float deltaTime, float lookaheadTime) { }

	public void ApplyTransformDelta(Vector3 positionDelta) { }

	public bool IsEmpty() { }

	public Vector3 PredictPosition(float lookaheadTime) { }

	public Vector3 PredictPositionDelta(float lookaheadTime) { }

	public void Reset() { }

}

