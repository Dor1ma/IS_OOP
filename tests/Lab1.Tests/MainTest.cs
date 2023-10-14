using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Ships;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Services;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class MainTest
{
    [Theory]
    [MemberData(nameof(TestDataGenerator.GetFirstTestData), MemberType = typeof(TestDataGenerator))]
    public void ShuttleAndAvgurInHighDensityNebulaeTest(
        Ship ship,
        ICollection<IObstacle> obstaclesList,
        int length,
        CheckerMessages expected)
    {
        var route = new Route();
        var space = new HighDensityNebulae(obstaclesList, length);
        route.AddSegment(space);

        CheckerMessages shipMessage = ShipChecker.PermeabilityCheck(ship, route);

        Assert.Equal(expected, shipMessage);
    }

    [Theory]
    [MemberData(nameof(TestDataGenerator.GetSecondTestData), MemberType = typeof(TestDataGenerator))]
    public void VaklasAndVaklasWithPhotonsTest(
        Ship ship,
        ICollection<IObstacle> obstaclesList,
        int length,
        CheckerMessages expected)
    {
        var route = new Route();
        obstaclesList.Add(new AntimatterFlashes());
        var highDensityNebulae = new HighDensityNebulae(obstaclesList, length);
        route.AddSegment(highDensityNebulae);

        CheckerMessages shipMessage = ShipChecker.PermeabilityCheck(ship, route);

        Assert.Equal(expected, shipMessage);
    }

    [Theory]
    [MemberData(nameof(TestDataGenerator.GetThirdTestData), MemberType = typeof(TestDataGenerator))]
    public void VaklasAvgurAndMeredianAgainstCosmoWhaleTest(
        Ship ship,
        ICollection<IObstacle> obstacles,
        int length,
        CheckerMessages expected)
    {
        var route = new Route();
        obstacles.Add(new CosmoWhales());
        var nitrinoParticleNebulae = new NitrinoParticleNebulae(obstacles, length);
        route.AddSegment(nitrinoParticleNebulae);

        CheckerMessages shipMessage = ShipChecker.PermeabilityCheck(ship, route);

        Assert.Equal(expected, shipMessage);
    }

    [Theory]
    [MemberData(nameof(TestDataGenerator.GetFourthTestData), MemberType = typeof(TestDataGenerator))]
    public void ShuttleAndVaklasInSpaceCostCheck(
        Shuttle shuttle,
        Vaklas vaklas,
        ICollection<IObstacle> obstacles,
        int length,
        CheckerMessages shuttleResult,
        CheckerMessages vaklasResult)
    {
        var route = new Route();
        var space = new Space(obstacles, length);
        route.AddSegment(space);
        var ships = new Collection<Ship>();
        var fuelExchange = new FuelExchange();

        CheckerMessages shuttleMessage = ShipChecker.PermeabilityCheck(shuttle, route);
        CheckerMessages vaklasMessage = ShipChecker.PermeabilityCheck(vaklas, route);
        ShipChecker.CostCount(shuttle, route, fuelExchange);
        ShipChecker.CostCount(vaklas, route, fuelExchange);
        ships.Add(shuttle);
        ships.Add(vaklas);
        Ship comparingResult = shuttle;
        Ship comparingTest = ShipChecker.ShipsComparator(ships);

        Assert.Equal(shuttleResult, shuttleMessage);
        Assert.Equal(vaklasResult, vaklasMessage);
        Assert.Equal(comparingResult, comparingTest);
    }

    [Theory]
    [MemberData(nameof(TestDataGenerator.GetFifthTestData), MemberType = typeof(TestDataGenerator))]
    public void AvgurAndStellaInHighDensityNebulaeTest(
        Ship ship,
        ICollection<IObstacle> obstacles,
        int length,
        CheckerMessages expected)
    {
        var route = new Route();
        var highDensityNebulae = new HighDensityNebulae(obstacles, length);
        route.AddSegment(highDensityNebulae);

        CheckerMessages shipMessage = ShipChecker.PermeabilityCheck(ship, route);

        Assert.Equal(expected, shipMessage);
    }

    [Theory]
    [MemberData(nameof(TestDataGenerator.GetSixthTestData), MemberType = typeof(TestDataGenerator))]
    public void ShuttleAndVaklasInNitrinoParcticleNebulaeTest(
        Ship ship,
        ICollection<IObstacle> obstacles,
        int length,
        CheckerMessages expected)
    {
        var route = new Route();
        var nitrinoParticleNebulae = new NitrinoParticleNebulae(obstacles, length);
        route.AddSegment(nitrinoParticleNebulae);

        CheckerMessages shipMessage = ShipChecker.PermeabilityCheck(ship, route);

        Assert.Equal(expected, shipMessage);
    }

    [Theory]
    [MemberData(nameof(TestDataGenerator.GetSeventhTestData), MemberType = typeof(TestDataGenerator))]
    public void ShuttleAndVaklasInMultipleSegmentsRoute(
        Shuttle shuttle,
        Vaklas vaklas,
        ICollection<IObstacle> firstSegmentObstacles,
        ICollection<IObstacle> secondSegmentObstacles,
        ICollection<IObstacle> thirdSegmentObstacles,
        int segmentOneLength,
        int segmentTwoLength,
        int segmentThreeLength,
        CheckerMessages shuttleResult,
        CheckerMessages vaklasResult)
    {
        var route = new Route();
        for (int i = 0; i < 4; i++)
        {
            firstSegmentObstacles.Add(new Asteroid());
        }

        secondSegmentObstacles.Add(new Meteor());
        var spaceOne = new Space(firstSegmentObstacles, segmentOneLength);
        var spaceTwo = new Space(secondSegmentObstacles, segmentTwoLength);
        var nitrinoParticleNebulae = new NitrinoParticleNebulae(thirdSegmentObstacles, segmentThreeLength);
        route.AddSegment(spaceOne);
        route.AddSegment(spaceTwo);
        route.AddSegment(nitrinoParticleNebulae);

        CheckerMessages shuttleMessage = ShipChecker.PermeabilityCheck(shuttle, route);
        CheckerMessages vaklasMessage = ShipChecker.PermeabilityCheck(vaklas, route);

        Assert.Equal(shuttleResult, shuttleMessage);
        Assert.Equal(vaklasResult, vaklasMessage);
    }

    private class TestDataGenerator : IEnumerable<object[]>
    {
        private const bool NoPhotons = false;
        private const bool WithPhotons = true;
        private const int LowSegmentLength = 100;
        private const int MediumSegmentLength = 200;
        private const int HighSegmentLength = 400;

        private static readonly ICollection<IObstacle> FirstTestObstacles =
            new List<IObstacle>(0);

        private static readonly ICollection<IObstacle> SecondTestObstacles =
            new List<IObstacle>(1);

        private static readonly ICollection<IObstacle> ThirdTestObstacles =
            new List<IObstacle>(1);

        private static readonly ICollection<IObstacle> FourthTestObstacles =
            new List<IObstacle>(0);

        private static readonly ICollection<IObstacle> FifthTestObstacles =
            new List<IObstacle>(0);

        private static readonly ICollection<IObstacle> SixthTestObstacles =
            new List<IObstacle>(0);

        private static readonly ICollection<IObstacle> SeventhTestFirstSegmentObstacles =
            new List<IObstacle>(4);

        private static readonly ICollection<IObstacle> SeventhTestSecondSegmentObstacles =
            new List<IObstacle>(1);

        private static readonly ICollection<IObstacle> SeventhTestThirdSegmentObstacles =
            new List<IObstacle>(0);
        public static IEnumerable<object[]> GetFirstTestData()
        {
            yield return new object[]
            {
                new Shuttle(), FirstTestObstacles, MediumSegmentLength, CheckerMessages.UnsuitableEngine,
            };
            yield return new object[]
            {
                new Avgur(NoPhotons), FirstTestObstacles, MediumSegmentLength, CheckerMessages.InsufficientEnginesRange,
            };
        }

        public static IEnumerable<object[]> GetSecondTestData()
        {
            yield return new object[]
            {
                new Vaklas(NoPhotons), SecondTestObstacles, LowSegmentLength, CheckerMessages.CrewIsDead,
            };
            yield return new object[]
            {
                new Vaklas(WithPhotons), SecondTestObstacles, LowSegmentLength, CheckerMessages.Ok,
            };
        }

        public static IEnumerable<object[]> GetThirdTestData()
        {
            yield return new object[]
            {
                new Vaklas(NoPhotons), ThirdTestObstacles, MediumSegmentLength, CheckerMessages.ShipDestroyed,
            };
            yield return new object[]
            {
                new Avgur(NoPhotons), ThirdTestObstacles, MediumSegmentLength, CheckerMessages.Ok,
            };
            yield return new object[]
            {
                new Meredian(NoPhotons), ThirdTestObstacles, MediumSegmentLength, CheckerMessages.Ok,
            };
        }

        public static IEnumerable<object[]> GetFourthTestData()
        {
            yield return new object[]
            {
                new Shuttle(), new Vaklas(NoPhotons),
                FourthTestObstacles, LowSegmentLength,
                CheckerMessages.Ok, CheckerMessages.Ok,
            };
        }

        public static IEnumerable<object[]> GetFifthTestData()
        {
            yield return new object[]
            {
                new Avgur(NoPhotons), FifthTestObstacles,
                HighSegmentLength, CheckerMessages.InsufficientEnginesRange,
            };
            yield return new object[]
            {
                new Stella(NoPhotons), FifthTestObstacles,
                HighSegmentLength, CheckerMessages.Ok,
            };
        }

        public static IEnumerable<object[]> GetSixthTestData()
        {
            yield return new object[] { new Shuttle(), SixthTestObstacles, LowSegmentLength, CheckerMessages.UnsuitableEngine };
            yield return new object[] { new Vaklas(NoPhotons), SixthTestObstacles, LowSegmentLength, CheckerMessages.Ok };
        }

        public static IEnumerable<object[]> GetSeventhTestData()
        {
            yield return new object[]
            {
                new Shuttle(), new Vaklas(NoPhotons),
                SeventhTestFirstSegmentObstacles, SeventhTestSecondSegmentObstacles,
                SeventhTestThirdSegmentObstacles, LowSegmentLength, MediumSegmentLength,
                HighSegmentLength, CheckerMessages.ShipDestroyed, CheckerMessages.Ok,
            };
        }

        public IEnumerator<object[]> GetEnumerator()
        {
            throw new NotValidImplementationException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}