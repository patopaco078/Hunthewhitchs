using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillLightController : MonoBehaviour
{
    [SerializeField] float magnitud = 0.02f;
    [SerializeField] DeathController deathController;
    [SerializeField] Transform player;
    [SerializeField] Light FlashLight;
    float Duration = 0f;
    bool IsShake = false;
    float scale = 0;
    float elapsed = 0f;

    private void Update()
    {
        if (IsShake)
        {
            if (FlashLight.intensity == 1)
            {
                Vector3 originalPosition = player.localPosition;

                Duration = 3;

                if (elapsed < Duration)
                {

                    if (scale < 1)
                        scale += Time.deltaTime / 2;
                    else
                        scale = 1;
                    float x = Random.Range(-0.1f, 0.1f) * magnitud * scale;
                    float y = Random.Range(-0.1f, 0.1f) * magnitud * scale;

                    player.localPosition = new Vector3(x, y, originalPosition.z);

                    elapsed += Time.deltaTime;
                    if (elapsed > 3)
                        deathController.Kill();
                }
            }
            if (!(FlashLight.intensity == 1))
            {
                elapsed = 0f;
                scale = 0;
            }
        }
    }

    public void ActiveSnakeKill()
    {
        IsShake = true;
    }
}
