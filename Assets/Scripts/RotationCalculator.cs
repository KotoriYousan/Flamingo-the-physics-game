using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCalculator : MonoBehaviour
{
    private Vector2 oldVector2;
    private Vector2 newVector2;

    private Vector2 oldLeftLeg;
    private Vector2 newLeftLeg;
    private Vector2 oldRightLeg;
    private Vector2 newRightLeg;
    private Vector2 oldRightWing;
    private Vector2 newRightWing;
    private Vector2 oldLeftWing;
    private Vector2 newLeftWing;

    [SerializeField]
    private GameObject leftLeg;
    [SerializeField]
    private GameObject rightLeg;
    [SerializeField]
    private GameObject leftWing;
    [SerializeField]
    private GameObject rightWing;


    private float leftLegAngle;
    private float rightLegAngle;
    private float leftWingAngle;
    private float rightWingAngle;

    void Start()
    {

        oldVector2 = this.transform.position;

        oldLeftLeg = leftLeg.transform.position;
        oldRightLeg = rightLeg.transform.position;
        oldLeftWing = leftWing.transform.position;
        oldRightWing = rightWing.transform.position;

    //    Debug.Log(oldVector2);
    //    Debug.Log(Mathf.Atan2((oldVector2 - oldLeftLeg).y, (oldVector2 - oldLeftLeg).x) * Mathf.Rad2Deg);
    }
    void Update()
    {
        StartCoroutine(MovePoint());
        
        
    }

    private IEnumerator MovePoint()
    {
        yield return new WaitForSeconds(0.2f);
        newVector2 = this.transform.position;

        newLeftLeg = leftLeg.transform.position;
        newRightLeg = rightLeg.transform.position;
        newLeftWing = leftWing.transform.position;
        newRightWing = rightWing.transform.position;

        //float angle = Vector2.Angle(oldVector2, newVector2);
        
        //left leg
        float angleLL = Mathf.Atan2((newVector2-newLeftLeg).y, (newVector2 - newLeftLeg).x) * Mathf.Rad2Deg - Mathf.Atan2((oldVector2 - oldLeftLeg).y, (oldVector2 - oldLeftLeg).x) * Mathf.Rad2Deg;
        if (angleLL < -180)
            angleLL = 360 + angleLL;
        this.setLeftLegAngle(angleLL);
//        Debug.Log("angleLL= " + getLeftLegAngle().ToString());

        //Right Leg
        float angleRL = Mathf.Atan2((newVector2 - newRightLeg).y, (newVector2 - newRightLeg).x) * Mathf.Rad2Deg - Mathf.Atan2((oldVector2 - oldRightLeg).y, (oldVector2 - oldRightLeg).x) * Mathf.Rad2Deg;
        if (angleRL < -180)
            angleRL = 360 + angleRL;
        this.setRightLegAngle(angleRL);
 //       Debug.Log("angleRL= " + getRightLegAngle().ToString());


        //left wing
        float angleLW = Mathf.Atan2((newVector2 - newLeftWing).y, (newVector2 - newLeftWing).x) * Mathf.Rad2Deg - Mathf.Atan2((oldVector2 - oldLeftWing).y, (oldVector2 - oldLeftWing).x) * Mathf.Rad2Deg;
        if (angleLW < -180)
            angleLW = 360 + angleLW;
        this.setLeftWingAngle(angleLW);
  //      Debug.Log("angleLW= " + getLeftWingAngle().ToString());


        //right wing
        float angleRW = Mathf.Atan2((newVector2 - newRightWing).y, (newVector2 - newRightWing).x) * Mathf.Rad2Deg - Mathf.Atan2((oldVector2 - oldRightWing).y, (oldVector2 - oldRightWing).x) * Mathf.Rad2Deg;
        if (angleRW < -180)
            angleRW = 360 + angleRW;
        this.setRightWingAngle(angleRW);
  //      Debug.Log("angleRW= " + getRightWingAngle().ToString());
    }


    public float getLeftLegAngle()
    {
        return leftLegAngle;
    }

    public void setLeftLegAngle(float ang)
    {
        leftLegAngle = ang;
    }



    public float getRightLegAngle()
    {
        return rightLegAngle;
    }

    public void setRightLegAngle(float ang)
    {
        rightLegAngle = ang;
    }



    public float getLeftWingAngle()
    {
        return leftWingAngle;
    }

    public void setLeftWingAngle(float ang)
    {
        leftWingAngle = ang;
    }



    public float getRightWingAngle()
    {
        return rightWingAngle;
    }

    public void setRightWingAngle(float ang)
    {
        rightWingAngle = ang;
    }

}
