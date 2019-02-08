using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public bool playerDead;

    // Start is called before the first frame update
    void Start()
    {
        playerDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < -10)
        {
            playerDead = true;
            StartCoroutine("Die");
        }
    }

    IEnumerator Die()
    {
        SceneManager.LoadScene("Level");
        yield return null;
    }
}
