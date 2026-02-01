using UnityEngine;

public class FlipSc : MonoBehaviour
{
    public Transform graphicsTransform; // ѕерет€гн≥ть сюди об'Їкт Graphics з ≥нспектора
    public bool isFacingLeft = true;

    void Update()
    {
        float move = Input.GetAxisRaw("Horizontal");

        if (move < 0 && !isFacingLeft)
        {
            Flip();
        }
        else if (move > 0 && isFacingLeft)
        {
            Flip();
        }
    }

    void Flip()
    {
        isFacingLeft = !isFacingLeft;
        Vector3 scale = graphicsTransform.localScale;
        scale.x *= -1; // ≤нвертуЇмо масштаб по горизонтал≥
        graphicsTransform.localScale = scale;
    }
}
