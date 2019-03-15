using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifePlayer : MonoBehaviour {

    // Use this for initialization

    public Sprite[] heartsprites;
    [SerializeField]public int amountlife;
    private Rigidbody2D player;
    private Canvas cvs;

    Vector3 positionimg = new Vector3(109, -13, 0);
    Quaternion quaternion = new Quaternion(0, 0, 0, 0);

    void Start () {

        //capturar o player
        // player = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();

        cvs = GameObject.FindGameObjectWithTag("LifeUI").GetComponent<Canvas>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(1))
        {
            SetAmountLife();
        }
    }


    public void SetImageLife(int x) //recebe por parametro o lugar no vector
    {
 
    }

    public void SetAmountLife()
    {
        for (int x = 0; x <= this.amountlife; x++)
        {
            GameObject NewObj = new GameObject(); //Create the GameObject
            Image NewImage = NewObj.AddComponent<Image>(); //Add the Image Component script
            NewImage.sprite = heartsprites[0]; //Set the Sprite of the Image Component on the new GameObject
            NewObj.GetComponent<RectTransform>().SetParent(cvs.transform); //Assign the newly created Image GameObject as a Child of the Parent Panel.

            NewObj.transform.Translate(positionimg);


            NewObj.SetActive(true); //Activate the GameObject

            positionimg = new Vector3(200, -13, 0);
        }
    }


}
