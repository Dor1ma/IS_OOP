using Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;

public class Space : Environment
{
    public Space(int asteroidsCount, int meteorsCount, int length)
    {
        if (asteroidsCount != 0)
        {
            for (int i = 0; i < asteroidsCount; i++)
            {
                Obstacles.Add(new Asteroid());
            }
        }

        if (meteorsCount != 0)
        {
            for (int i = 0; i < meteorsCount; i++)
            {
                Obstacles.Add(new Meteor());
            }
        }

        EnvironmentLength = length;
    }
}