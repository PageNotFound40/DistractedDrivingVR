using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speed = 10f;
    public float wobbleSpeed = 0.5f;
    public float position = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(transform.position.z >= 50f){
            Vector3 carPos = new Vector3(transform.position.x, transform.position.y, -50f);
            transform.position = carPos;
        }
        if(transform.position.x >= 1.3f){
            wobbleSpeed = -0.5f;
        }
        if(transform.position.x <= -1.3f){
            wobbleSpeed = 0.5f;
        }

        transform.position += new Vector3(wobbleSpeed, 0f, speed) * Time.deltaTime; 
    }
}