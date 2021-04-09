using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class CalculatePoints : MonoBehaviour
{
    public Text TotalScoreText;

    [SerializeField]
    private GameObject bird;


    private int timer = 0;
    private bool startTimer = true;

    private Dictionary<int, List<float>> danceDictionary;

    [SerializeField]
    private GameObject good;
    [SerializeField]
    private GameObject bad;

    [SerializeField]
    private GameObject five;
    [SerializeField]
    private GameObject four;
    [SerializeField]
    private GameObject three;
    [SerializeField]
    private GameObject two;
    [SerializeField]
    private GameObject one;

    // Start is called before the first frame update
    void Start()
    {

        GameManager.totalPoints = 0;

        ReadDanceMoveList();
        

    }

    // Update is called once per frame
    void Update()
    {
        if (startTimer)
        {
            StartCoroutine(CountTime());
            startTimer = false;
        }
        
    }

    private IEnumerator CountTime()
    {
        yield return new WaitForSeconds(1);
        timer++;
        startTimer = true;
        Debug.Log("current time: "+timer);

        CountDown(timer);

        float p = CompareDanceMove(timer);
        Debug.Log("points: "+p);
        GameManager.totalPoints += (int)p;
        Debug.Log(GameManager.totalPoints);
        UpdateTotalPoints();

        if (p == 0)
        {
            good.SetActive(false);
            bad.SetActive(false);
        }

        if (timer == 215) //215
        {
            if(GameManager.totalPoints > 1000)
            {
                SceneManager.LoadScene(7);
            }
            else
            {
                SceneManager.LoadScene(6);
            }
            
        }
    }
    
    private void CountDown(int t)
    {
        if (danceDictionary.ContainsKey(t + 5))
        {
            five.SetActive(true);
        }else if(danceDictionary.ContainsKey(t + 4))
        {
            five.SetActive(false);
            four.SetActive(true);
        }else if(danceDictionary.ContainsKey(t + 3))
        {
            four.SetActive(false);
            three.SetActive(true);
        }else if (danceDictionary.ContainsKey(t + 2))
        {
            three.SetActive(false);
            two.SetActive(true);
        }else if(danceDictionary.ContainsKey(t + 1))
        {
            two.SetActive(false);
            one.SetActive(true);
        }else if (danceDictionary.ContainsKey(t))
        {
            one.SetActive(false);
        }
    }

    private void ReadDanceMoveList()
    {
        //list order: LL, RL, LW, RW
        danceDictionary = new Dictionary<int, List<float>>();
        float[] tempfloat = { -20, 20, 90, 190 };
        danceDictionary.Add(18, new List<float>(tempfloat));
        float[] tempfloat2 = { 5, 0, 90, 190};
        danceDictionary.Add(33, new List<float>(tempfloat2));
        float[] tempfloat3 = { 0, -60, 70, 30 };
        danceDictionary.Add(48, new List<float>(tempfloat3));
        float[] tempfloat4 = { -30, 15, 70, 30 };
        danceDictionary.Add(63, new List<float>(tempfloat4));
        float[] tempfloat5 = { -45, -45, 90, 190 };
        danceDictionary.Add(78, new List<float>(tempfloat5));
        float[] tempfloat6 = { 10, -45, 90, 180 };
        danceDictionary.Add(93, new List<float>(tempfloat6));
        float[] tempfloat7 = { 30, -30, 0, 180 };
        danceDictionary.Add(108, new List<float>(tempfloat7));
        float[] tempfloat8 = { 10, -45, 70, 30 };
        danceDictionary.Add(123, new List<float>(tempfloat8));
        float[] tempfloat9 = { -45, -5, 50, 180 };
        danceDictionary.Add(138, new List<float>(tempfloat9));
        float[] tempfloat10 = { 10, -45, 90, 180 };
        danceDictionary.Add(153, new List<float>(tempfloat10));
        float[] tempfloat11 = { 0, -60, 70, 30 };
        danceDictionary.Add(168, new List<float>(tempfloat11));
        float[] tempfloat12 = { -45, -45, 90, 190 };
        danceDictionary.Add(183, new List<float>(tempfloat12));
        float[] tempfloat13 = { 30, -30, 0, 180 };
        danceDictionary.Add(198, new List<float>(tempfloat13));
        float[] tempfloat14 = { -20, 20, 90, 190 };
        danceDictionary.Add(213, new List<float>(tempfloat14));
        
    }

    private float CompareDanceMove(int time)
    {
        float points = 0;

        if (danceDictionary.ContainsKey(time))
        {
    //        Debug.Log("Key:{0},Value:{1}" + "1" + danceDictionary[time]);

            float deltaLL = System.Math.Abs(danceDictionary[time][0] - bird.GetComponent<RotationCalculator>().getLeftLegAngle());
            float deltaRL = System.Math.Abs(danceDictionary[time][1] - bird.GetComponent<RotationCalculator>().getRightLegAngle());
            float deltaLW = System.Math.Abs(danceDictionary[time][2] - bird.GetComponent<RotationCalculator>().getLeftWingAngle());
            float deltaRW = System.Math.Abs(danceDictionary[time][3] - bird.GetComponent<RotationCalculator>().getRightWingAngle());


            float pointsLL = Math.Abs(180 - deltaLL) / 180 * 25;
            float pointsRL = Math.Abs(180 - deltaRL) / 180 * 25;
            float pointsLW = Math.Abs(180 - deltaLW) / 180 * 25;
            float pointsRW = Math.Abs(180 - deltaRW) / 180 * 25;

            //    bird.GetComponent<RotationCalculator>().getLeftLegAngle();

            points = pointsLL + pointsLW + pointsRL + pointsRW;

            ShowGrade((int)points);
        }

        

        return points;
    }

    private void UpdateTotalPoints()
    {
        TotalScoreText.text = GameManager.totalPoints.ToString();
    }
    
    private void ShowGrade(int p)
    {
        if(p >= 75)
        {
            good.SetActive(true);
        }
        else if(p>0)
        {
            bad.SetActive(true);
        }
    }

}
