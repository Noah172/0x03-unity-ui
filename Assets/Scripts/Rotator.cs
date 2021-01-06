using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rot = 45;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rot * Time.deltaTime, 0, 0);
    }
}
