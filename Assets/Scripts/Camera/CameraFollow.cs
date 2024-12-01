using UnityEngine;

/// <summary>
/// The CameraFollow script allows the camera to follow the specified target.
/// </summary>
public class CameraFollow : MonoBehaviour, ICameraFollow
{
    /// <summary>
    /// The speed at which the camera follows the target.
    /// </summary>
    public float FollowSpeed = 2f;

    /// <summary>
    /// The target that the camera will follow.
    /// </summary>
    public Transform Target;  

    private ICameraPositionCalculator positionCalculator;

    private void Start()
    {
        positionCalculator = new CameraPositionCalculator();
    }

    private void Update()
    {
        Follow();
    }

    /// <summary>
    /// Moves the camera towards the calculated position of the target.
    /// </summary>
    public void Follow()
    {
        if (Target != null)
        {
            Vector3 newPos = positionCalculator.CalculatePosition(Target);
            transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed * Time.deltaTime);
        }
        else
        {
            Debug.LogWarning("Target is not assigned in CameraFollow.");
        }
    }
}
