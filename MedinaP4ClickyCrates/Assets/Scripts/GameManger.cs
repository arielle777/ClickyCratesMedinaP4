using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    private float spawnrate = 1.0f;
    private int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTarget());

        score = 0;
        UpdateScore(0);

    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator SpawnTarget()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnrate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
        

    }

   public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score :" + score;
    }

}
