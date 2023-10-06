using System.Collections;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;
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
        string shuttleResult,
        string avgurResult)
    {
        var space = new HighDensityNebulae(flashesCount, length);
        route.AddSegment(space);

        string shuttleMessage = ShipChecker.PermeabilityCheck(shuttle, route);
        string avgurMessage = ShipChecker.PermeabilityCheck(avgur, route);

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
        string vaklasResult,
        string vaklasWithPhotonsResult)
    {
        var highDensityNebulae = new HighDensityNebulae(flashesCount, length);
        route.AddSegment(highDensityNebulae);

        string vaklasMessage = ShipChecker.PermeabilityCheck(vaklas, route);
        string vaklasWithPhotonsMessage = ShipChecker.PermeabilityCheck(vaklasWithPhotons, route);

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
        string vaklasResult,
        string avgurResult,
        string meredianResult)
    {
        var nitrinoParticleNebulae = new NitrinoParticleNebulae(whalesCount, length);
        route.AddSegment(nitrinoParticleNebulae);

        string vaklasMessage = ShipChecker.PermeabilityCheck(vaklas, route);
        string avgurMessage = ShipChecker.PermeabilityCheck(avgur, route);
        string meredianMessage = ShipChecker.PermeabilityCheck(meredian, route);

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
        int asteroidsCount,
        int meteorsCount,
        int length,
        string shuttleResult,
        string vaklasResult,
        int activePasmaCost,
        int gravityMatterCost)
    {
        var space = new Space(asteroidsCount, meteorsCount, length);
        route.AddSegment(space);
        var fuelExchange = new FuelExchange(activePasmaCost, gravityMatterCost);
        var ships = new Ship[2];

        string shuttleMessage = ShipChecker.PermeabilityCheck(shuttle, route);
        string vaklasMessage = ShipChecker.PermeabilityCheck(vaklas, route);
        ShipChecker.CostCount(shuttle, route, fuelExchange);
        ShipChecker.CostCount(vaklas, route, fuelExchange);
        ships[0] = shuttle;
        ships[1] = vaklas;
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
        int flashesCount,
        int length,
        string avgurResult,
        string stellaResult)
    {
        var highDensityNebulae = new HighDensityNebulae(flashesCount, length);
        route.AddSegment(highDensityNebulae);

        string avgurMessage = ShipChecker.PermeabilityCheck(avgur, route);
        string stellaMessage = ShipChecker.PermeabilityCheck(stella, route);

        Assert.Equal(avgurResult, avgurMessage);
        Assert.Equal(stellaResult, stellaMessage);
    }

    [Theory]
    [ClassData(typeof(SixthTestData))]
    public void ShuttleAndVaklasInNitrinoParcticleNebulaeTest(
        Shuttle shuttle,
        Vaklas vaklas,
        Route route,
        int whalesCount,
        int length,
        string shuttleResult,
        string vaklasResult)
    {
        var nitrinoParticleNebulae = new NitrinoParticleNebulae(whalesCount, length);
        route.AddSegment(nitrinoParticleNebulae);

        string shuttleMessage = ShipChecker.PermeabilityCheck(shuttle, route);
        string vaklasMessage = ShipChecker.PermeabilityCheck(vaklas, route);

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
        int firstMeteorsCount,
        int secondAsteroidsCount,
        int secondMeteorsCount,
        int whalesCount,
        int segmentOneLength,
        int segmentTwoLength,
        int segmentThreeLength,
        string shuttleResult,
        string vaklasResult)
    {
        var spaceOne = new Space(firstAsteroidsCount, firstMeteorsCount, segmentOneLength);
        var spaceTwo = new Space(secondAsteroidsCount, secondMeteorsCount, segmentTwoLength);
        var nitrinoParticleNebulae = new NitrinoParticleNebulae(whalesCount, segmentThreeLength);
        route.AddSegment(spaceOne);
        route.AddSegment(spaceTwo);
        route.AddSegment(nitrinoParticleNebulae);

        string shuttleMessage = ShipChecker.PermeabilityCheck(shuttle, route);
        string vaklasMessage = ShipChecker.PermeabilityCheck(vaklas, route);

        Assert.Equal(shuttleResult, shuttleMessage);
        Assert.Equal(vaklasResult, vaklasMessage);
    }

    private class FirstTestData : IEnumerable<object[]>
    {
        private const bool AreAvgurDeflectorsPhoton = false;
        private const int FlashesCount = 0;
        private const int SegmentLength = 200;
        private const string ShuttleExpected = "Unsuitable engine";
        private const string AvgurExpected = "Insufficient engines range";

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
        private const string FirstVaklasExpected = "Crew is dead";
        private const string SecondVaklasExpected = "OK";
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
        private const string VaklasExpected = "Ship destroyed";
        private const string AvgurExpected = "OK";
        private const string MeredianExpected = "OK";
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
        private const int AsteroidsCount = 0;
        private const int MeteorsCount = 0;
        private const int SegmentLength = 100;
        private const string ShuttleExpected = "OK";
        private const string VaklasExpected = "OK";
        private const int ActivePlasmaCost = 10;
        private const int GravityMatterCost = 25;
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[]
            {
                new Shuttle(),
                new Vaklas(WithoutPhotons),
                new Route(),
                AsteroidsCount,
                MeteorsCount,
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
        private const int FlashesCount = 0;
        private const int SegmentLength = 400;
        private const string AvgurExpected = "Insufficient engines range";
        private const string StellaExpected = "OK";
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[]
            {
                new Avgur(WithoutPhotons),
                new Stella(WithoutPhotons),
                new Route(),
                FlashesCount,
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
        private const int WhalesCount = 0;
        private const int SegmentLength = 100;
        private const string ShuttleExpected = "Unsuitable engine";
        private const string VaklasExpected = "OK";

        private readonly List<object[]> _data = new List<object[]>
        {
            new object[]
            {
                new Shuttle(),
                new Vaklas(WithoutPhotons),
                new Route(),
                WhalesCount,
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
        private const int FirstSpaceMeteorsCount = 0;
        private const int SecondSpaceAsteroidsCount = 0;
        private const int SecondSpaceMeteorsCount = 1;
        private const int WhalesCount = 0;
        private const int FirstSegmentLength = 100;
        private const int SecondSegmentLength = 200;
        private const int ThirdSegmentLength = 400;
        private const string ShuttleExpected = "Ship destroyed";
        private const string VaklasExpected = "OK";

        private readonly List<object[]> _data = new List<object[]>
        {
            new object[]
            {
                new Shuttle(),
                new Vaklas(WithoutPhotons),
                new Route(),
                FirstSpaceAsteroidsCount,
                FirstSpaceMeteorsCount,
                SecondSpaceAsteroidsCount,
                SecondSpaceMeteorsCount,
                WhalesCount,
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