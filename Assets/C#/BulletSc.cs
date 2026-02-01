using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class BulletSc : MonoBehaviour
{
    public float spd = 1000f;
    public float time = 30f;
    public float dmg = 30f;
    void Start()
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(gameObject.transform.right * spd);
    }
    void Update()
    {
        Destroy(gameObject, time);
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Destroyable")) 
        {
            HpSc hp = collision.gameObject.GetComponent<HpSc>();
            if (hp != null) 
            {
                hp.Dmg(dmg);
            }
            DestroySelf();
        }
    }
    
    void DestroySelf()
    {
        Destroy(gameObject);
    }
}
