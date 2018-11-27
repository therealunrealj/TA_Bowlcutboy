using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class BowlcutGame : MonoBehaviour {

    const int Health = 100;
    const int Damage = 50;

    public Text BoyIntroText;
    public Text RottlingerIntroText;
    public Text AttackInfo;
    public Text AttackOne;
    public Text DamageText;
    public Text Dodge;
    public Text HealthDoctor;
    public Text HealthBoy;

    private SceneLoader sceneLoader;
    private State actualState;

    private void IntroSetupUI()
    {
        BoyIntroText.enabled = true;

    }

    // Use this for initialization
    void Start () {
        //I dont know what to do
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
