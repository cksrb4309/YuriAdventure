using UnityEngine;

public class Drop : MonoBehaviour
{

    public int positionX;
    public int positionY;

    float width = 0.84f;

    public void Initialize(int x, int y)
    {
        positionX = x;
        positionY = y;

        // 위치 계산 및 설정
        float calculatedPositionX = (-2.5f + positionX) * width;
        float calculatedPositionY = ((-2.0f) + positionY) * width;
        transform.localPosition = new Vector2(calculatedPositionX, calculatedPositionY);
    }

    void Start()
    {
    }

    void Update()
    {

    }
    
    void OnMouseUp()
    {
        float calculatedPositionX = (-2.5f + positionX) * width;
        float calculatedPositionY = ((-2.0f) + positionY) * width;
        transform.localPosition = new Vector2(calculatedPositionX, calculatedPositionY);

    }

    public void Move(int x, int y)
    {
        positionX = x;
        positionY = y;

        // 위치 계산 및 설정
        float calculatedPositionX = (-2.5f + positionX) * width;
        float calculatedPositionY = ((-2.0f) + positionY) * width;
        transform.localPosition = new Vector2(calculatedPositionX, calculatedPositionY);
    }
}
