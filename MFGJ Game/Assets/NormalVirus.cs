
using UnityEngine;

public class NormalVirus : MonoBehaviour
{
    public Transform cell;
    public Rigidbody2D rb;
    public float speed;
    void Update()
    {
        rb.position = Vector2.MoveTowards(transform.position, cell.position, speed * Time.deltaTime);
    }
}
