using UnityEngine;

public class AspectRatioController : MonoBehaviour
{
    void Start()
    {
        Camera.main.aspect = 9f / 16f; 
    }
}
