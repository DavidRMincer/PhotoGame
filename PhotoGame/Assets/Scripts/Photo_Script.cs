using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Photo_Script : MonoBehaviour
{
    public Material photoMat;
    public float fadeDuration;

    internal bool changed = false;

    public IEnumerator PhotoFadeIn()
    {
        changed = true;
        Material prevMat = GetComponent<MeshRenderer>().material;
        float counter = 0;

        GetComponent<MeshRenderer>().material = photoMat;
        Debug.Log(GetComponent<MeshRenderer>().material);

        while (counter < fadeDuration)
        {
            yield return new WaitForSeconds(Time.deltaTime);
            counter = (counter + Time.deltaTime >= fadeDuration) ? fadeDuration : counter + Time.deltaTime;

            GetComponent<MeshRenderer>().material.color = Color.Lerp(new Color(1, 1, 1, 0), Color.white, counter / fadeDuration);
            //GetComponent<MeshRenderer>().material.Lerp(prevMat, photoMat, counter / fadeDuration);
        }
        Debug.Log(GetComponent<MeshRenderer>().material);
        yield return null;
    }
}
