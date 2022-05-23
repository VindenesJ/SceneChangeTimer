using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneChanger : MonoBehaviour
{

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SceneTimer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator SceneTimer()
    {
        float sceneAmount = 5;
        for(int i = 0; i <= sceneAmount; i++)
        {
            yield return new WaitForSeconds(10);
            SceneManager.LoadScene($"Scene{i}");        }
    }
}
