using UnityEngine;
using static UnityEditor.PlayerSettings;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public ParticleSystem EffectParticle;
    public GameObject Vehicle;
    public GameObject Apple;
    [SerializeField] int VehicleMax;
    [SerializeField] int AppleMax;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        EffectParticle = GameObject.FindGameObjectWithTag("Particle").GetComponent<ParticleSystem>();
    }

    private void Start()
    {
        InvokeRepeating("CreatVehicle", 0, 5f);
        Invoke("CreatApple", 0f);
    }

    private void CreatVehicle()
    {     
        for (int i = 0; i < VehicleMax; i++)
        {
            float x = -11f;
            float z = Random.Range(-4.3f, 27f);
            Vector3 pos = new Vector3(x, 0, z);

            Vehicle.GetComponent<Transform>().position = pos;

            Instantiate(Vehicle);
        }
    }

    private void CreatApple()
    {
        for (int i = 0; i < AppleMax; i++)
        {
            float x = Random.Range(-9.5f, 9.5f);
            float z = Random.Range(-4.3f, 27f);
            Vector3 pos = new Vector3(x, 0, z);

            Apple.GetComponent<Transform>().position = pos;

            Instantiate(Apple);
        }
    }

    public void GameOver()
    {
        Time.timeScale = 0.0f;
    }
}