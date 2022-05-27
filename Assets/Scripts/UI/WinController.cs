using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinController : MonoBehaviour
{
    [SerializeField] GameObject WinScreen;

    [SerializeField] WitchGlobalController witchGlobalController;
    [SerializeField] CartasController cartasController;

    private void Start()
    {
        WinScreen.SetActive(false);
    }

    public void WinCondition()
    {
        if(witchGlobalController.Oryx && cartasController.Oryx)
        {
            Win();
        }
        if (witchGlobalController.Xya && cartasController.Xya)
        {
            Win();
        }
        if (witchGlobalController.Hanah && cartasController.Hanah)
        {
            Win();
        }
        if (witchGlobalController.Anie && cartasController.Anie)
        {
            Win();
        }
    }

    void Win()
    {
        WinScreen.SetActive(true);
        StartCoroutine(ReloadScene());
    }

    IEnumerator ReloadScene()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Map");
    }
}
