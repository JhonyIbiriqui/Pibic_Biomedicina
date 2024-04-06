using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeBar : MonoBehaviour
{
    [SerializeField] private float lifeCurrent;
    [SerializeField] private GameObject grennBar;
    private RectTransform transformGrennBar;
    private float newLife;
    private float heightBarlife;
    [SerializeField] private float perLife;

    void Start()
    {
        transformGrennBar = (RectTransform)grennBar.transform;
        heightBarlife = transformGrennBar.sizeDelta.y;
        transformGrennBar.sizeDelta = new Vector2(400f, heightBarlife);
        
    }
    
    public void alteraVida(string origem)
    {
        lifeCurrent = transformGrennBar.sizeDelta.x;
        switch (origem)
        {
            case "Lanche":
                perLife = 0.8f;
                break;
            case "Pizza":
                perLife = 0.9f;
                break;
            case "Maçã":
                perLife = 1.1f;
                break;
            default:
                break;
        }
        
        newLife = lifeCurrent * perLife;
        lifeCurrent = transformGrennBar.sizeDelta.x;
        transformGrennBar.sizeDelta = new Vector2(newLife,heightBarlife);
    }

    void update()
    {
    

    }
}