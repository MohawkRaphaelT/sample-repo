using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager gameManager;

    public static GameManager Instance
    {
        get
        {
            if (gameManager == null)
            {
                Debug.LogError("Game Manager does not exist!");
            }

            return gameManager;
        }
    }

    private void Awake()
    {
        if (gameManager == null)
            gameManager = this;
        else
            Destroy(this.gameObject);

        //
        DontDestroyOnLoad(this);
    }



    /////
    public int lives = 3;
    public int health = 3;


}
