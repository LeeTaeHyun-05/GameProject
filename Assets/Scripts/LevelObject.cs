using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class LevelObject : MonoBehaviour
{
    public string nextLevel;

    public void MoveToNextLevel()
    {
        EditorSceneManager.LoadScene(nextLevel);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
