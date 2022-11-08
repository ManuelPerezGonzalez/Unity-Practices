using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    int             counter;
    Rigidbody       rb;
    public Text     points;
    public Text     win;
    public float    speed;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        counter += 1;
        IncreasePoints();
        if (counter >= 6)
        {
            win.text = "You win!\nTotal points: " + counter;
            win.gameObject.SetActive(true);
            points.gameObject.SetActive(false);
        }
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        counter = 0;
        IncreasePoints();
        win.gameObject.SetActive(false);
    }

    private void FixedUpdate()
    {
        float horizontalMov = Input.GetAxis("Horizontal");
        float verticalMov = Input.GetAxis("Vertical");
        Vector3 mov = new Vector3(horizontalMov, 0, verticalMov);
        rb.AddForce(mov*speed);
    }

    private void IncreasePoints()
    {
        points.text = "Points: " + counter;
    }
}
