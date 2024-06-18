using System.Collections.ObjectModel;

namespace DefensiveCopy;

public class TopThree
{
    private string[] winners;
    private bool isNational;

    public TopThree(string[] winners, bool isNational)
    {
        this.winners = winners.ToArray(); // create defensive copy and store the memory address of the copy  
        this.isNational = isNational;
    }

    public string[] DisplayWinners()
    {
        return winners.ToArray(); //create a defensive copy and return the memory address of newly created copy
    }
}