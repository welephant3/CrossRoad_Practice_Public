using UnityEngine;
using UnityEngine.UIElements;

public class VehicleInteraction : MonoBehaviour
{
    float MaxSpeed = 1f;
    float MinSpeed = 5f;
    float speed;
    Vector3 currentPosition;

    private void Awake()
    {
        currentPosition = GetComponent<Transform>().position;
        speed = Random.Range(MinSpeed, MaxSpeed);
    }
        
    private void Update()
    {
        float x = speed * Time.deltaTime;
        currentPosition.x += x;
        gameObject.transform.position = currentPosition;

        if (gameObject.transform.position.x >= 11f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("À¸¾Ç!");
            Destroy(other);
            GameManager.Instance.GameOver();
        }
    }
}
