using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
    private enum SwitchState
    {
        Off,
        On,
        Blink
    }

    public Collider bola;
    public AudioManager audioManager;
    public VFXManager vfxManager;
    public Material offMaterial;
    public Material onMaterial;
    public ScoreManager scoreManager;
    public float score;

    private SwitchState state;
    private Renderer renderer;
    

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        Set(false);
        StartCoroutine(BlinkTimerStart(5));
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other == bola)
        {
            vfxManager.PlayPlaneVFX(gameObject.transform.position);
            Toggle();
        }
    }

    private void Set(bool active)
    {
        if (active == true)
        {
            state = SwitchState.On;
            renderer.material = onMaterial;

            StopAllCoroutines();
        }
        else
        {
            state = SwitchState.Off;
            renderer.material = offMaterial;
            StartCoroutine(BlinkTimerStart(5));
        }
    }

    private IEnumerator Blink(int times)
    {
        state = SwitchState.Blink;

        for (int i = 0; i < times; i++)
        {
            renderer.material = onMaterial;
            yield return new WaitForSeconds(0.5f);
            renderer.material = offMaterial;
            yield return new WaitForSeconds(0.5f);
        }

        state = SwitchState.Off;
        StartCoroutine(BlinkTimerStart(5));
    }

    private void Toggle()
    {
        scoreManager.AddScore(score);
        if (state == SwitchState.On)
        {
            audioManager.PlayPlaneOnSFX(gameObject.transform.position);
            Set(false);
        }
        else
        {
            audioManager.PlayPlaneOffSFX(gameObject.transform.position);
            Set(true);
        }
    }

    private IEnumerator BlinkTimerStart(float time)
    {
        yield return new WaitForSeconds(time);
        StartCoroutine(Blink(2));
    }
}
