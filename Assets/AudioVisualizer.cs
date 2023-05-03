using UnityEngine;
using UnityEngine.Events;

public class AudioVisualizer : MonoBehaviour
{
    private AudioSource source;
    public float average;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }

    private void Update()
    {
        float[] samples = new float[735];
        source.clip.GetData(samples, source.timeSamples);

        float sum = 0;
        foreach (var sample in samples)
        {
            sum += Mathf.Abs(sample);
        }
        average = sum / 735;

        
    }
}
