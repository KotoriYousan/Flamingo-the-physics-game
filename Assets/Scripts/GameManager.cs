using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

using System.Collections.Generic;

public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;
    //   private int 

    public Button StartButton;

    public static int totalPoints = 0;

    private void Awake()
    {
        if (instance == null){
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);

        InitGame();

    }

  /*  public void SetTotalPoints(int p)
    {
        totalPoints = p;
    }

    public float GetTotalPoints()
    {
        return totalPoints;
    }*/

    void InitGame()
    {
        SceneManager.LoadScene(0);

//        StartButton = GameObject.Find("Start Button").GetComponent<Button>();
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
