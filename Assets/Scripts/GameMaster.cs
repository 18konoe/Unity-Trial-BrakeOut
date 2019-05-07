using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    public int BlockNum;

    public float NowTime;
    // Start is called before the first frame update
    void Start()
    {
        NowTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        NowTime += Time.deltaTime;
        if (BlockNum <= 0)
        {
            GameOver($"{NowTime:F0}秒でクリアできた");
        }
    }

    public void GameOver(string resultMessage)
    {
        DataSender.resultMessage = resultMessage;
        SceneManager.LoadScene("Result");
    }
}
