using UnityEngine;

/// <summary>
/// Calculates the position where the camera should be based on the target's position.
/// </summary>
public class CameraPositionCalculator : ICameraPositionCalculator
{
    /// <summary>
    /// Calculates the position where the camera should be based on the target's position.
    /// </summary>
    /// <param name="target">The target transform whose position will be used.</param>
    /// <returns>The calculated position for the camera.</returns>
    public Vector3 CalculatePosition(Transform target)
    {
        return new Vector3(target.position.x, target.position.y, -10f);
    }
}