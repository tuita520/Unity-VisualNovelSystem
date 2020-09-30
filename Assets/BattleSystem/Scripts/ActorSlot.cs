﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ActorSlot : MonoBehaviour
{

    public bool IsAI;

    public Image Face;
    public Transform AnimationSpawnPoint;
    public CharacterBase Actor;
    public void SetGraphics(){
        Debug.Log(Actor.FacePath);
        Face.sprite = Resources.Load<Sprite>(Actor.FacePath);
    }


    public TextMeshProUGUI HP;
    public Image HPForeground;
    public TextMeshProUGUI MP;
    public Image MPForeground;
    public void UpdateStats(){
        HP.text = Actor.CurStats.HP.ToString();
        HPForeground.fillAmount = 100 * Actor.CurStats.HP / Actor.MaxStats.HP;

        MP.text = Actor.CurStats.MP.ToString();
        MPForeground.fillAmount = 100 * Actor.CurStats.MP / Actor.MaxStats.MP;
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