using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereDancer : MonoBehaviour
{
    public float size = 5;
    public float power = 3;
    private float finalSize;
    public int shrinkSpeed = 3;

    public AudioVisualizer visualizer;

    public void Update()
    {
        var musicPower = (1 + Mathf.Pow(visualizer.average, power) * size);

        if (musicPower > finalSize)
        {
            finalSize = musicPower;
        }
        else
        {
            finalSize -= shrinkSpeed * Time.deltaTime;
        }

        transform.localScale = Vector3.one * finalSize;

        transform.Rotate(0, 0, musicPower);
    }
}
