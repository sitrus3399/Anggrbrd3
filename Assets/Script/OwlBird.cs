using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwlBird : Bird
{
    public GameObject bird;
    private Vector3 scaleExlopde;
    private bool isExplode = false;

    public override void Explode()
    {
        if (!isExplode)
        {
            scaleExlopde = new Vector3(1f, 1f, 1f);
            bird.transform.localScale += scaleExlopde;
            bird.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            StartCoroutine(DestroyAfter(.1f));
            isExplode = true;
        }
    }

    private IEnumerator DestroyAfter(float second)
    {
        yield return new WaitForSeconds(second);
        Destroy(gameObject);
    }
}
