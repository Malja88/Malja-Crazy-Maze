using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageHint : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(StageFinalHint());
    }
    IEnumerator StageFinalHint()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}
