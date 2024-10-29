using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScore : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _starText;
    [SerializeField] private TextMeshProUGUI _killText;
    [SerializeField] private TextMeshProUGUI _deathText;
    [SerializeField] private TextMeshProUGUI _totalText;
    [SerializeField] private TextMeshProUGUI _rankText;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
        _starText.text = Score.score.ToString("000");
        _killText.text = Enemy.killcounter.ToString("000");
        _deathText.text = Death.deathcounter.ToString("000");
        int TotalScore = Score.score * 10 + Enemy.killcounter * 15 - Death.deathcounter * 100;
        _totalText.text = (TotalScore).ToString();

        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            if (TotalScore >= 220 && TotalScore <= 260)
                _rankText.text = "S+";
            else if (TotalScore >= 180 && TotalScore <= 219)
                _rankText.text = "A+";
            else if (TotalScore >= 125 && TotalScore <= 179)
                _rankText.text = "B+";
            else if (TotalScore >= 0 && TotalScore <= 124)
                _rankText.text = "C";
            else
            {
                _rankText.text = "unranked";

            }

        }
        else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            if (TotalScore >= 420 && TotalScore <= 490)
                _rankText.text = "S+";
            else if (TotalScore >= 320 && TotalScore <= 419)
                _rankText.text = "A+";
            else if (TotalScore >= 170 && TotalScore <= 319)
                _rankText.text = "B+";
            else if (TotalScore >= 0 && TotalScore <= 169)
                _rankText.text = "C";
            else
            {
                _rankText.text = "unranked";

            }
        }
        else if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            if (TotalScore >= 600 && TotalScore <= 720)
                _rankText.text = "S+";
            else if (TotalScore >= 400 && TotalScore <= 599)
                _rankText.text = "A+";
            else if (TotalScore >= 250 && TotalScore <= 399)
                _rankText.text = "B+";
            else if (TotalScore >= 0 && TotalScore <= 249)
                _rankText.text = "C";
            else
            {
                _rankText.text = "unranked";

            }
        }
        else if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            if (TotalScore >= 800 && TotalScore <= 950)
                _rankText.text = "S+";
            else if (TotalScore >= 550 && TotalScore <= 799)
                _rankText.text = "A+";
            else if (TotalScore >= 300 && TotalScore <= 549)
                _rankText.text = "B+";
            else if (TotalScore >= 0 && TotalScore <= 299)
                _rankText.text = "C";
            else
            {
                _rankText.text = "unranked";

            }
        }
        else if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            if (TotalScore > 1000 && TotalScore <= 1180)
                _rankText.text = "S+";
            else if (TotalScore >= 700 && TotalScore <= 1000)
                _rankText.text = "A+";
            else if (TotalScore >= 400 && TotalScore <= 699)
                _rankText.text = "B+";
            else if (TotalScore >= 0 && TotalScore <= 399)
                _rankText.text = "C";
            else
            {
                _rankText.text = "unranked";
            }
        }
    }
}
