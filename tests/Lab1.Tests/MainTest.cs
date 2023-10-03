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
        bool avgurResult,
        string meredianResult)
    {
        var nitrinoParticleNebulae = new NitrinoParticleNebulae(whalesCount, length);
        route.AddSegment(nitrinoParticleNebulae);

        string vaklasMessage = ShipChecker.PermeabilityCheck(vaklas, route);
        ShipChecker.PermeabilityCheck(avgur, route);
        string meredianMessage = ShipChecker.PermeabilityCheck(meredian, route);
        Assert.Equal(vaklasResult, vaklasMessage);
        Assert.Equal(avgurResult, avgur.IsBroken);
        Assert.Equal(meredianResult, meredianMessage);
    }

    [Theory]
    [ClassData(typeof(FourthTestData))]
    public void FourthCase(
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

        string shuttleMessage = ShipChecker.PermeabilityCheck(shuttle, route);
        string vaklasMessage = ShipChecker.PermeabilityCheck(vaklas, route);
        Assert.Equal(shuttleResult, shuttleMessage);
        Assert.Equal(vaklasResult, vaklasMessage);

        var fuelExchange = new FuelExchange(activePasmaCost, gravityMatterCost);
        ShipChecker.CostCount(shuttle, route, fuelExchange);
        ShipChecker.CostCount(vaklas, route, fuelExchange);
        Ship comparingResult = shuttle;
        var ships = new Ship[] { shuttle, vaklas };
        Ship comparingTest = ShipChecker.ShipsComparator(ships);
        Assert.Equal(comparingResult, comparingTest);
    }

    [Fact]
    public void FifthCase()
    {
        var avgur = new Avgur(false);
        var stella = new Stella(false);
        var route = new Route();

        int[][] requirements = new int[1][];
        requirements[0] = new[] { 2, 400, 0, 0, 0, 0 };
        route.CreateRoute(1, requirements);

        string avgurMessage = ShipChecker.PermeabilityCheck(avgur, route);
        string avgurResult = "Insufficient engines range";
        string stellaMessage = ShipChecker.PermeabilityCheck(stella, route);
        string stellaResult = "OK";
        Assert.Equal(avgurResult, avgurMessage);
        Assert.Equal(stellaResult, stellaMessage);
    }

    [Fact]
    public void SixthCase()
    {
        var shuttle = new Shuttle(false);
        var vaklas = new Vaklas(false);
        var route = new Route();

        int[][] requirements = new int[1][];
        requirements[0] = new[] { 3, 100, 0, 0, 0, 0 };
        route.CreateRoute(1, requirements);

        string shuttleMessage = ShipChecker.PermeabilityCheck(shuttle, route);
        string shuttleResult = "Unsuitable engine";
        string vaklasMessage = ShipChecker.PermeabilityCheck(vaklas, route);
        string vaklasResult = "OK";
        Assert.Equal(shuttleResult, shuttleMessage);
        Assert.Equal(vaklasResult, vaklasMessage);
    }

    [Fact]
    public void SeventhCase()
    {
        var shuttle = new Shuttle(false);
        var vaklas = new Vaklas(false);
        var route = new Route();

        int[][] requirements = new int[3][];
        requirements[0] = new[] { 1, 100, 4, 0, 0, 0 };
        requirements[1] = new[] { 1, 200, 0, 2, 0, 0 };
        requirements[2] = new[] { 3, 400, 0, 0, 0, 0 };
        route.CreateRoute(1, requirements);

        string shuttleMessage = ShipChecker.PermeabilityCheck(shuttle, route);
        string shuttleResult = "Ship destroyed";
        string vaklasMessage = ShipChecker.PermeabilityCheck(vaklas, route);
        string vaklasResult = "OK";
        Assert.Equal(shuttleResult, shuttleMessage);
        Assert.Equal(vaklasResult, vaklasMessage);
    }

    private class FirstTestData : IEnumerable<object[]>
    {
        private const bool AreShuttleDeflectorsPhoton = false;
        private const bool AreAvgurDeflectorsPhoton = false;
        private const int FlashesCount = 0;
        private const int SegmentLength = 200;
        private const string ShuttleExpected = "Unsuitable engine";
        private const string AvgurExpected = "Insufficient engines range";

        private readonly List<object[]> _data = new List<object[]>
        {
            new object[]
            {
                new Shuttle(AreShuttleDeflectorsPhoton),
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
        private const bool AvgurExpected = false;
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
                new Shuttle(WithoutPhotons),
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
}