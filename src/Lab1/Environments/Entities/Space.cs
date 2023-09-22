using Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;

public class Space : Environment
{
    public Space(int asteroidsCount, int meteorsCount, int length)
    {
        FirstObstacle = new Asteroid();
        SecondObstacle = new Meteor();
        FirstObstaclesCount = asteroidsCount;
        SecondObstaclesCount = meteorsCount;
        EngineRequired = "Impulse";
        EnvironmentLength = length;
    }
}