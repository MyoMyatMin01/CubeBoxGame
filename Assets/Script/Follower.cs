using UnityEngine;

public class Follower : MonoBehaviour
{
    public Transform player;
    public Vector3 backCamera;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + backCamera;
    }
}
