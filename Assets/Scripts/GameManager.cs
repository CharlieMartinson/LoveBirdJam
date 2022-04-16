using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
//this is the manager of the game
{
    public GameObject Home;
    public GameObject MainMenu;
    public GameObject Instructions;
    public GameObject Stats;
    public GameObject ThreeDeeScene;
    public void SetMainMenu()
    {
        SetScreen (MainMenu);
    }

   public void SetScreen(GameObject screen)
    {
        GameObject[] arrayOfScreens = new GameObject[]
        {
            Home,MainMenu,Instructions,Stats,ThreeDeeScene
        };

        foreach (GameObject toCompare in arrayOfScreens)
        {
            if (toCompare == screen)
            {
                toCompare.SetActive(true);
            }
            else
            {
                toCompare.SetActive(false);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        SetScreen(Home);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
