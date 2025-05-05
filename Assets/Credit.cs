using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credit : MonoBehaviour
{
    public RectTransform creditText;
    public float scrollSpeed = 50f;
    public float endPositionY = 1000f;

    void Start()
    {
        StartScrolling();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }

    void StartScrolling()
    {
        creditText.DOAnchorPosY(endPositionY, scrollSpeed)
            .SetEase(Ease.Linear)
            .OnComplete(() => Debug.Log("End Credit Finished"));
    }
}
