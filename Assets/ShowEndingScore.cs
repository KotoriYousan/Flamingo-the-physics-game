using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowEndingScore : MonoBehaviour
{
    public Text EndingScoreText;

    private void Awake()
    {
        EndingScoreText.GetComponent<Text>().text = GameManager.totalPoints.ToString();
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
