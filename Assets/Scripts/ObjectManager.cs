using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public static ObjectManager Instance;

    
    public List<GameObject> artifacts = new List<GameObject>();

    [SerializeField]
    private DinoTimer dinoTimer;

    [SerializeField]
    private GameManager gameManager;

    [SerializeField]
    private GameObject winText;


    // Start is called before the first frame update
    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Update()
    {
        if (artifacts.Count == 0)
        {
            dinoTimer.timerIsOn = false;
            print("Turn timer off");
            gameManager.timerOff = true;
            winText.SetActive(true);
        }
    }

public void UpdateList(GameObject arifact)
    {
        if (artifacts.Contains(arifact) && artifacts.Count != 0)
        {
            artifacts.Remove(arifact);


        }

    }
}
    