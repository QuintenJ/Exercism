using System;
using System.Collections.Generic;
using System.Linq;

/*\
Manage a game player's High Score list.

Your task is to build a high-score component of the classic Frogger game, 
one of the highest selling and addictive games of all time, and a classic of the arcade era.
 Your task is to write methods that return the highest score from the list, the last added score and the three highest scores.
*/
public class HighScores
{
    private List<int> highScoresList;

    public HighScores(List<int> list)
    {
        highScoresList = list;
    }

    public List<int> Scores() => highScoresList;


    public int Latest() => highScoresList.Last();


    public int PersonalBest() => highScoresList.Max();


    public List<int> PersonalTopThree() => highScoresList.OrderByDescending(i => i).Take(3).ToList();

}