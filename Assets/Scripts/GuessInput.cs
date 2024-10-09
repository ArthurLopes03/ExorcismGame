using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GuessInput : MonoBehaviour
{
    public Demon demon;

    public Temperment tempermentGuess;

    public Type typeGuess;

    [SerializeField]
    List<Type> types;

    [SerializeField]
    List<Temperment> temperments;

    public void ChangeTypeGuess(int index)
    {
        switch (index)
        {
            case 0:
                typeGuess = types[0]; break;
            case 1:
                typeGuess = types[1]; break;
            case 2:
                typeGuess = types[2]; break;
        }
    }

    public void ChangeTemperamentGuess(int index)
    {
        switch (index)
        {
            case 0:
                tempermentGuess = temperments[0]; break;
            case 1:
                tempermentGuess= temperments[1]; break;
            case 2:
                tempermentGuess = temperments[2]; break;
            case 3:
                tempermentGuess = temperments[3]; break;
        }
    }

    public void MakeGuess()
    {
        if (typeGuess == demon.type && tempermentGuess == demon.temperment)
        {
            Win();
        }
        else { Lose(); }
    }

    private void Win()
    {
        SceneManager.LoadScene("Win Scene");
    }

    private void Lose()
    {
        SceneManager.LoadScene("Lose Scene");
    }
}
