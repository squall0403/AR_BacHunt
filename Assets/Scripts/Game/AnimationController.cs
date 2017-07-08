using UnityEngine;
using System.Collections;


public class AnimationController : MonoBehaviour {
    [SerializeField]
    private float rotateSpeed = 1.0f; //In rotations per second


    [SerializeField]
    private float floatSpeed = 0.5f; //In cycles per second


    [SerializeField]
    private float movementDistance = 0.5f; //The maximum distance


    private float startingY;


    private bool isMovingUp = true; 


    // Use this for initialization
    void Start () {
    startingY = transform.position.y;    
    transform.Rotate (transform.up, Random.Range (0,360f));
        StartCoroutine (Spin ());
        StartCoroutine (Float ()); 
    }


private IEnumerator Spin()
    {
        while (true)
        {    
            transform.Rotate (transform.up, 360 * rotateSpeed * Time.deltaTime);
            yield return 0;
        }
    }


    private IEnumerator Float()
    {
        while (true)
        {
            float newY = transform.position.y + (isMovingUp ? 1 : -1) * 2 * movementDistance * floatSpeed * Time.deltaTime;
            if (newY > startingY + movementDistance)
            {
                newY = startingY + movementDistance;
                isMovingUp = false;
            }
            else if (newY < startingY)
            {
                newY = startingY;
                isMovingUp = true;
            }


            transform.position = new Vector3(transform.position.x, newY, transform.position.z);
            yield return 0;
        }
    }
    
}
