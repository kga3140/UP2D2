using UnityEngine;

public class HpSc : MonoBehaviour
{
    public float hp = 100f;
    void Start()
    {
        
    }

    void Update()
    {
        if (hp <= 0)
        { 
            Destroy(gameObject);
        }
    }
    public void Dmg(float damage) 
    {
        hp -= damage;
    }
}
