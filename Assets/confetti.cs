using UnityEngine;
using FlutterUnityIntegration;

public class confettiscript : MonoBehaviour
{
    public ParticleSystem confetti;

    public void PlayConfetti()
    {
        if (!confetti.isPlaying)
        {
            confetti.Play();
            Debug.Log("Confetti started!");
        }

        // Optional: notify Flutter when done
        Invoke(nameof(SendBackToFlutter), 3f);
    }

    void SendBackToFlutter()
    {
        UnityMessageManager.Instance.SendMessageToFlutter("ConfettiFinished");
    }
}
