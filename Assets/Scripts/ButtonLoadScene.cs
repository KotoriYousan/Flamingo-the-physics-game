using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonLoadScene : MonoBehaviour
{
    public int levelnumber;
    private Button button;

    public void LoadByIndex()
    {
        SceneManager.LoadScene(levelnumber);
    }

    // Start is called before the first frame update
    void Start()
    {
        button = this.gameObject.GetComponent<Button>();
        button.onClick.AddListener(LoadByIndex);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
