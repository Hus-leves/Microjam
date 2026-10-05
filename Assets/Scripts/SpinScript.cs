using UnityEngine;

public class SpinScript : MonoBehaviour
{
    private float rotate = 0f;
    private void FixedUpdate()
    {
        rotate += 7f;
        transform.rotation = Quaternion.Euler(0f, 0f, rotate);
    }
}
