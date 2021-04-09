using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControlReturn : MonoBehaviour
{
    // Start is called before the first frame update
    public void Control_R () {
      Debug.Log("doing something");
  		SceneManager.LoadScene ("Title");
  	}
}
