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
    [ClassData(typeof(FirstTestData))]
    public void ShuttleAndAvgurInHighDensityNebulaeTest(
        Shuttle shuttle,
        Avgur avgur,
        Route route,
        int flashesCount,
        int length,
        CheckerMessages shuttleResult,
        CheckerMessages avgurResult)
    {
        IReadOnlyCollection<IObstacle> flashes = new List<IObstacle>(flashesCount);
        var space = new HighDensityNebulae(flashes, length);
        route.AddSegment(space);

        CheckerMessages shuttleMessage = ShipChecker.PermeabilityCheck(shuttle, route);
        CheckerMessages avgurMessage = ShipChecker.PermeabilityCheck(avgur, route);

        Assert.Equal(shuttleResult, shuttleMessage);
        Assert.Equal(avgurResult, avgurMessage);
    }

    [Theory]
    [ClassData(typeof(SecondTestData))]
    public void VaklasAndVaklasWithPhotonsTest(
        Vaklas vaklas,
        Vaklas vaklasWithPhotons,
        Route route,
        int flashesCount,
        int length,
        CheckerMessages vaklasResult,
        CheckerMessages vaklasWithPhotonsResult)
    {
        var flashes = new Collection<IObstacle>();
        for (int i = 0; i < flashesCount; i++)
        {
            flashes.Add(new AntimatterFlashes());
        }

        var highDensityNebulae = new HighDensityNebulae(flashes, length);
        route.AddSegment(highDensityNebulae);

        CheckerMessages vaklasMessage = ShipChecker.PermeabilityCheck(vaklas, route);
        CheckerMessages vaklasWithPhotonsMessage = ShipChecker.PermeabilityCheck(vaklasWithPhotons, route);

        Assert.Equal(vaklasResult, vaklasMessage);
        Assert.Equal(vaklasWithPhotonsResult, vaklasWithPhotonsMessage);
    }

    [Theory]
    [ClassData(typeof(ThirdTestData))]
    public void VaklasAvgurAndMeredianAgainstCosmoWhaleTest(
        Vaklas vaklas,
        Avgur avgur,
        Meredian meredian,
        Route route,
        int whalesCount,
        int length,
        CheckerMessages vaklasResult,
        CheckerMessages avgurResult,
        CheckerMessages meredianResult)
    {
        var whales = new Collection<IObstacle>();
        for (int i = 0; i < whalesCount; i++)
        {
            whales.Add(new CosmoWhales());
        }

        var nitrinoParticleNebulae = new NitrinoParticleNebulae(whales, length);
        route.AddSegment(nitrinoParticleNebulae);

        CheckerMessages vaklasMessage = ShipChecker.PermeabilityCheck(vaklas, route);
        CheckerMessages avgurMessage = ShipChecker.PermeabilityCheck(avgur, route);
        CheckerMessages meredianMessage = ShipChecker.PermeabilityCheck(meredian, route);

        Assert.Equal(vaklasResult, vaklasMessage);
        Assert.Equal(avgurResult, avgurMessage);
        Assert.Equal(meredianResult, meredianMessage);
    }

    [Theory]
    [ClassData(typeof(FourthTestData))]
    public void ShuttleAndVaklasInSpaceCostCheck(
        Shuttle shuttle,
        Vaklas vaklas,
        Route route,
        int length,
        CheckerMessages shuttleResult,
        CheckerMessages vaklasResult,
        int activePasmaCost,
        int gravityMatterCost)
    {
        IReadOnlyCollection<IAmOnlyForSpace> obstaclesData = new Collection<IAmOnlyForSpace>();
        var space = new Space(obstaclesData, length);
        route.AddSegment(space);
        var ships = new Collection<Ship>();
        var fuelExchange = new FuelExchange(activePasmaCost, gravityMatterCost);

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
    [ClassData(typeof(FifthTestData))]
    public void AvgurAndStellaInHighDensityNebulaeTest(
        Avgur avgur,
        Stella stella,
        Route route,
        int length,
        CheckerMessages avgurResult,
        CheckerMessages stellaResult)
    {
        IReadOnlyCollection<IObstacle> obstaclesData = new Collection<IObstacle>();
        var highDensityNebulae = new HighDensityNebulae(obstaclesData, length);
        route.AddSegment(highDensityNebulae);

        CheckerMessages avgurMessage = ShipChecker.PermeabilityCheck(avgur, route);
        CheckerMessages stellaMessage = ShipChecker.PermeabilityCheck(stella, route);

        Assert.Equal(avgurResult, avgurMessage);
        Assert.Equal(stellaResult, stellaMessage);
    }

    [Theory]
    [ClassData(typeof(SixthTestData))]
    public void ShuttleAndVaklasInNitrinoParcticleNebulaeTest(
        Shuttle shuttle,
        Vaklas vaklas,
        Route route,
        int length,
        CheckerMessages shuttleResult,
        CheckerMessages vaklasResult)
    {
        var whales = new Collection<IObstacle>();
        var nitrinoParticleNebulae = new NitrinoParticleNebulae(whales, length);
        route.AddSegment(nitrinoParticleNebulae);

        CheckerMessages shuttleMessage = ShipChecker.PermeabilityCheck(shuttle, route);
        CheckerMessages vaklasMessage = ShipChecker.PermeabilityCheck(vaklas, route);

        Assert.Equal(shuttleResult, shuttleMessage);
        Assert.Equal(vaklasResult, vaklasMessage);
    }

    [Theory]
    [ClassData(typeof(SeventhTestData))]
    public void ShuttleAndVaklasInMultipleSegmentsRoute(
        Shuttle shuttle,
        Vaklas vaklas,
        Route route,
        int firstAsteroidsCount,
        int segmentOneLength,
        int segmentTwoLength,
        int segmentThreeLength,
        CheckerMessages shuttleResult,
        CheckerMessages vaklasResult)
    {
        var firstSpaceObstacles = new Collection<IAmOnlyForSpace>();
        for (int i = 0; i < firstAsteroidsCount; i++)
        {
            firstSpaceObstacles.Add(new Asteroid());
        }

        var secondSpaceObstacles = new Collection<IAmOnlyForSpace>();
        secondSpaceObstacles.Add(new Meteor());
        var spaceOne = new Space(firstSpaceObstacles, segmentOneLength);
        var spaceTwo = new Space(secondSpaceObstacles, segmentTwoLength);
        var whales = new Collection<IObstacle>();
        var nitrinoParticleNebulae = new NitrinoParticleNebulae(whales, segmentThreeLength);
        route.AddSegment(spaceOne);
        route.AddSegment(spaceTwo);
        route.AddSegment(nitrinoParticleNebulae);

        CheckerMessages shuttleMessage = ShipChecker.PermeabilityCheck(shuttle, route);
        CheckerMessages vaklasMessage = ShipChecker.PermeabilityCheck(vaklas, route);

        Assert.Equal(shuttleResult, shuttleMessage);
        Assert.Equal(vaklasResult, vaklasMessage);
    }

    private class FirstTestData : IEnumerable<object[]>
    {
        private const bool AreAvgurDeflectorsPhoton = false;
        private const int FlashesCount = 0;
        private const int SegmentLength = 200;
        private const CheckerMessages ShuttleExpected = CheckerMessages.UnsuitableEngine;
        private const CheckerMessages AvgurExpected = CheckerMessages.InsufficientEnginesRange;

        private readonly List<object[]> _data = new List<object[]>
        {
            new object[]
            {
                new Shuttle(),
                new Avgur(AreAvgurDeflectorsPhoton),
                new Route(),
                FlashesCount,
                SegmentLength,
                ShuttleExpected,
                AvgurExpected,
            },
        };
        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    private class SecondTestData : IEnumerable<object[]>
    {
        private const bool WithoutPhotons = false;
        private const bool WithPhotons = true;
        private const int FlashesCount = 1;
        private const int SegmentLength = 100;
        private const CheckerMessages FirstVaklasExpected = CheckerMessages.CrewIsDead;
        private const CheckerMessages SecondVaklasExpected = CheckerMessages.Ok;
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[]
            {
                new Vaklas(WithoutPhotons),
                new Vaklas(WithPhotons),
                new Route(),
                FlashesCount,
                SegmentLength,
                FirstVaklasExpected,
                SecondVaklasExpected,
            },
        };
        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    private class ThirdTestData : IEnumerable<object[]>
    {
        private const bool WithoutPhotons = false;
        private const int WhalesCount = 1;
        private const int SegmentLength = 200;
        private const CheckerMessages VaklasExpected = CheckerMessages.ShipDestroyed;
        private const CheckerMessages AvgurExpected = CheckerMessages.Ok;
        private const CheckerMessages MeredianExpected = CheckerMessages.Ok;
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[]
            {
                new Vaklas(WithoutPhotons),
                new Avgur(WithoutPhotons),
                new Meredian(WithoutPhotons),
                new Route(),
                WhalesCount,
                SegmentLength,
                VaklasExpected,
                AvgurExpected,
                MeredianExpected,
            },
        };
        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    private class FourthTestData : IEnumerable<object[]>
    {
        private const bool WithoutPhotons = false;
        private const int SegmentLength = 100;
        private const CheckerMessages ShuttleExpected = CheckerMessages.Ok;
        private const CheckerMessages VaklasExpected = CheckerMessages.Ok;
        private const int ActivePlasmaCost = 10;
        private const int GravityMatterCost = 25;
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[]
            {
                new Shuttle(),
                new Vaklas(WithoutPhotons),
                new Route(),
                SegmentLength,
                ShuttleExpected,
                VaklasExpected,
                ActivePlasmaCost,
                GravityMatterCost,
            },
        };
        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    private class FifthTestData : IEnumerable<object[]>
    {
        private const bool WithoutPhotons = false;
        private const int SegmentLength = 400;
        private const CheckerMessages AvgurExpected = CheckerMessages.InsufficientEnginesRange;
        private const CheckerMessages StellaExpected = CheckerMessages.Ok;
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[]
            {
                new Avgur(WithoutPhotons),
                new Stella(WithoutPhotons),
                new Route(),
                SegmentLength,
                AvgurExpected,
                StellaExpected,
            },
        };
        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    private class SixthTestData : IEnumerable<object[]>
    {
        private const bool WithoutPhotons = false;
        private const int SegmentLength = 100;
        private const CheckerMessages ShuttleExpected = CheckerMessages.UnsuitableEngine;
        private const CheckerMessages VaklasExpected = CheckerMessages.Ok;

        private readonly List<object[]> _data = new List<object[]>
        {
            new object[]
            {
                new Shuttle(),
                new Vaklas(WithoutPhotons),
                new Route(),
                SegmentLength,
                ShuttleExpected,
                VaklasExpected,
            },
        };
        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    private class SeventhTestData : IEnumerable<object[]>
    {
        private const bool WithoutPhotons = false;
        private const int FirstSpaceAsteroidsCount = 4;
        private const int FirstSegmentLength = 100;
        private const int SecondSegmentLength = 200;
        private const int ThirdSegmentLength = 400;
        private const CheckerMessages ShuttleExpected = CheckerMessages.ShipDestroyed;
        private const CheckerMessages VaklasExpected = CheckerMessages.Ok;

        private readonly List<object[]> _data = new List<object[]>
        {
            new object[]
            {
                new Shuttle(),
                new Vaklas(WithoutPhotons),
                new Route(),
                FirstSpaceAsteroidsCount,
                FirstSegmentLength,
                SecondSegmentLength,
                ThirdSegmentLength,
                ShuttleExpected,
                VaklasExpected,
            },
        };
        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}