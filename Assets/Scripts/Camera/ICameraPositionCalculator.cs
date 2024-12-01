using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
///  Interface for camera position calculators.
/// </summary>
public interface ICameraPositionCalculator
{
    /// <summary>
    /// Calculates the position where the camera should be based on the target's position.
    /// </summary>
    /// <param name="target"></param>
    /// <returns></returns>
    Vector3 CalculatePosition(Transform target);
}
