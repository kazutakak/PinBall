using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    //ボールが見える可能性のあるz軸の最大値
    private float visiblePosZ = -6.5f;

    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;

    //スコアを表示するテキスト
    private GameObject scoreText;
    //得点
    private int score = 0;
/*
    private int score2 = 0;
    private int score3 = 0;
    private int score4 = 0;
    private int totalscore = 0;
*/

    // Use this for initialization
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");

        //シーン中のscoreTextオブジェクトを取得
        this.scoreText = GameObject.Find("ScoreText");

        score = 0;
/*
        score2 = 0;
        score3 = 0;
        score4 = 0;
        totalscore = 0;
*/
        SetScore();

    }

    // Update is called once per frame
    void Update()
    {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }


    }

    void OnCollisionEnter(Collision other)
    {
        /*
                switch (tag)
                {
                    case "SmallStarTag":
                    case "SmallCloudTag":
                        this.score += 10;
                        break;
                    case "LargeStarTag":
                    case "LargeCloudTag":
                        this.score += 20;
                        break;
                }
        */

        if (other.gameObject.tag == "SmallStarTag" || other.gameObject.tag == "SmallCloudTag")
        {
            // スコアを加算
            this.score += 10;
            // AddScore(10);
        }
/*
        else if ()
        {
            // スコアを加算
            // this.score2 += 10;
            AddScore(10);

        }
        else if ()
        {
            // スコアを加算
            // this.score3 += 20;
            AddScore(20);

        }
*/
        else if (other.gameObject.tag == "LargeStarTag" || other.gameObject.tag == "LargeCloudTag")
        {
            // スコアを加算
            this.score += 20;
            // AddScore(20);

        }


        // AddScore();
        SetScore();

    }
/*
    public void AddScore(int score)
    {
        this.totalscore = this.score1 + this.score2 + this.score3 + this.score4 + score;
    }
*/
    void SetScore()
    {
        //ScoreText獲得した点数を表示
        this.scoreText.GetComponent<Text>().text = "Score " + this.score + "pt";
    }

}
