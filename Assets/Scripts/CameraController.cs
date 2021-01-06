using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public Vector3 follow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + follow;
    }
}
