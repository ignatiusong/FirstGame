using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public int zOffset;

    // Update is called once per frame
    void Update()
    {
        scoreText.text =  (player.position.z + zOffset).ToString("0");
    }
}
