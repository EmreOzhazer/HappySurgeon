using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oTwoBar : MonoBehaviour
{
    private Image OtwoBar;
    public float currentO;
    private float MaxO = 100f;
    GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        OtwoBar = GetComponent<Image>();
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        currentO = gameManager.oTwo;
        OtwoBar.fillAmount = currentO / MaxO;
        
    }
}
