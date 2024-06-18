using UnityEngine;
using UnityEngine.UIElements;

public class ItemInteraction : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            ParticleSystem particleSystem = GameManager.Instance.EffectParticle;
            particleSystem.transform.position = transform.position;
            ParticleSystem.EmissionModule em = particleSystem.emission;
            ParticleSystem.MainModule mm = particleSystem.main;
            particleSystem.Play();

            Debug.Log("³È³È");
            Destroy(gameObject);
        }
    }
}
