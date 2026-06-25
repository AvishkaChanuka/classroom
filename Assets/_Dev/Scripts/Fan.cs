using UnityEngine;

public class Fan : MonoBehaviour
{

    [SerializeField] RotateObject rotateObject;

    private void Start()
    {
        rotateObject.SetIsRotating(true);
    }
}
