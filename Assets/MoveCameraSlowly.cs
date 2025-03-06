using UnityEngine;

public class MoveCameraSlowly : MonoBehaviour
{
    public float _cameraSpeed;
    
    private void FixedUpdate() {
        transform.position += new Vector3(_cameraSpeed * 1, 0, 0);
    }
}
