using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class RandomSoundPlayer : MonoBehaviour
{
    [Header("Audio Settings")]
    public AudioClip[] clips;
    public float minDelay = 3f;
    public float maxDelay = 8f;

    [Header("Positioning")]
    public float radius = 5f; // Radius around camera for random positioning

    private AudioSource source;
    private Camera mainCamera;
    private float nextPlayTime;

    void Start()
    {
        // Get required components
        source = GetComponent<AudioSource>();
        mainCamera = Camera.main;

        // Warn if no camera found
        if (mainCamera == null)
        {
            Debug.LogWarning("No main camera found! Audio positioning will not work.");
        }

        ScheduleNext();
    }

    void Update()
    {
        // Check if it's time to play next sound and we have clips
        if (Time.time >= nextPlayTime && clips.Length > 0)
        {
            // Move to random position around camera
            if (mainCamera != null)
            {
                Vector3 randomOffset = Random.insideUnitSphere * radius;
                transform.position = mainCamera.transform.position + randomOffset;
            }

            // Play random clip
            source.clip = clips[Random.Range(0, clips.Length)];
            source.Play();

            ScheduleNext();
        }
    }

    void ScheduleNext()
    {
        // Schedule next sound between min and max delay
        nextPlayTime = Time.time + Random.Range(minDelay, maxDelay);
    }
}