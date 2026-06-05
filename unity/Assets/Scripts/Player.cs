using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 2;

    private void Awake()
    {
        this.health = GameManager.Instance.health;
    }

    private void OnDestroy()
    {
        GameManager.Instance.health = health;
    }
}
