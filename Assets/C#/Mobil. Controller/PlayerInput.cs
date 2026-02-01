using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public static PlayerInput Instance;
    public float horizontal;
    public bool jump;

    private void Awake()
    {
        Instance = this;
    }

    public void SetHorizontal(float value)
    {
        horizontal = value;
    }

    public void SetJump(bool state)
    {
        jump = state;
    }

}
