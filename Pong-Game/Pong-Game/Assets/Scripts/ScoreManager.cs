using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreLeftText;
    public Text scoreRightText;

    private int scoreLeft = 0;
    private int scoreRight = 0;

    public void AddPointLeft()
    {
        scoreLeft++;
        scoreLeftText.text = scoreLeft.ToString();
    }

    public void AddPointRight()
    {
        scoreRight++;
        scoreRightText.text = scoreRight.ToString();
    }
}
