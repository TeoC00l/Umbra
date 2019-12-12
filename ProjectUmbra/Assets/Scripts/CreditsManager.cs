using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsManager : MonoBehaviour
{

    private bool play = false;
    [SerializeField] private GameObject credits, targetObject;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PlayCredits());
    }

    private IEnumerator PlayCredits()
    {
        yield return new WaitForSeconds(5);
        play = true;
    }

    private void Update()
    {
        if (play)
        {
            targetObject.transform.position += Vector3.up * 15f * Time.deltaTime;
            credits.transform.position = new Vector3(credits.transform.position.x, targetObject.transform.position.y, credits.transform.position.z);
            //credits.transform.position = Vector3.MoveTowards(credits.transform.position, Vector3.up, 50 * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }
        if(targetObject.transform.position.y > 850)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
