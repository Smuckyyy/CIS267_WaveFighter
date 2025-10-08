using UnityEngine;

//We will only have one instance of this class
//It will be a singleton which will allow it to be accessed
//From all scripts will keep track of the following:
//-time (paused, playing, time left for level)
//-score (player score, GUI score)
//-levels (what level we are on, if all enemies are gone)

public class GameManager : MonoBehaviour
{
    //Make a static reference to the single instance of the GameManager
    public static GameManager instance { get; private set; }

    private void Awake()
    {
        //Check if there is an instance of GameManager has already been created
        if (instance != null && instance != this)
        {
            //If so, destroy this instance to enforce the singleton pattern
            Destroy(this.gameObject);
        }
        else
        {
            //In all other cases make an instance of GameManager
            instance = this;
        }

    }

    private int score = 23;
    public int getScore()
    {
        return score;
    }
    public void setScore(int s)
    {
        score = s;
    }
    
}
