using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform ts;
    public Vector3 offset;
    void FollowPlayer()
    {
        transform.position = ts.position + offset;
    }
}
