using UnityEngine;
using UnityEngine.UI;

public class CarSelector : MonoBehaviour
{
    public Button prevButton;
    public Button nextButton;

    private int currentCar;

    private void Awake()
    {
        ChangeCar(0);
    }

    private void SelectCar(int index)
    {
        prevButton.interactable = (index != 0);
        nextButton.interactable = (index != transform.childCount - 1);

        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(i == index);
        }
    }

    public void ChangeCar(int change)
    {
        currentCar += change;
        PlayerPrefs.SetInt("PlayerIndex", currentCar);
        SelectCar(currentCar);
    }
}
