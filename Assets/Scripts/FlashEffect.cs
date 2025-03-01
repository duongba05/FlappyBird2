using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class FlashEffect : MonoBehaviour
{
    public GameObject post;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(FlashEff());
    }

    IEnumerator FlashEff()
    {
        post.SetActive(true);
        yield return new WaitForSeconds(0.01f);
        post.SetActive(false);
    }
}
