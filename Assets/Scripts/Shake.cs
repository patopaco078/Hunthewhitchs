using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    [SerializeField] float magnitud = 0.02f;
    [SerializeField] Phantoms ScriptPhantoms;
    float Duration = 0f;
    public bool IsShake = false;
    float scale = 0;
    float elapsed = 0f;

    //Phantom inofensive
    float TimeInofensive = 0f;
    public bool inofensiveActive = false;
    [SerializeField] DeathController deathController;

    private void Update()
    {
        
        if (IsShake)
        {
            Vector3 originalPosition = transform.localPosition;

            Duration = ScriptPhantoms.DemonDuration;
            
            if (elapsed < Duration)
            {
                
                if (scale < 1)
                    scale += Time.deltaTime/2;
                else
                    scale = 1;
                float x = Random.Range(-0.1f, 0.1f) * magnitud * scale;
                float y = Random.Range(-0.1f, 0.1f) * magnitud * scale;

                transform.localPosition = new Vector3(x, y, originalPosition.z);
                
                elapsed += Time.deltaTime;
                if (elapsed > 3)
                    deathController.Kill();
            }
        }
        if (!IsShake)
        {
            elapsed = 0f;
            scale = 0;
        }

        if (inofensiveActive)
        {
            TimeInofensive += Time.deltaTime;
            if(TimeInofensive > ScriptPhantoms.InofensiveDuration)
            {
                inofensiveActive = false;
                ScriptPhantoms.DesactiveInofensive();
                TimeInofensive = 0f;
            }
        }
    }
}
