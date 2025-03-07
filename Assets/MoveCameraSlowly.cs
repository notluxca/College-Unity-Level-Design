using UnityEngine;

public class MoveCameraSlowly : MonoBehaviour
{
    public float _cameraSpeed;
    private Vector3 initialPos;

    private void Start() {
        initialPos = transform.position;
    }
    
    private void FixedUpdate() {
        transform.position += new Vector3(_cameraSpeed * 1, 0, 0);
        if(transform.position.x > 56){
            transform.position = initialPos;
        }
    }
}
