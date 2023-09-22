using Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Services;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class MainTest
{
    [Fact]
    public void FirstCase()
    {
        var shuttle = new Shuttle(false);
        var avgur = new Avgur(false);
        var route = new Route();

        int[][] requirements = new int[1][];

        // { EnvType, SegmentLength, Asteroids, Meteors, Flashes, Whales }
        requirements[0] = new[] { 2, 200, 0, 0, 0, 0 };
        route.CreateRoute(1, requirements);

        string shuttleMessage = ShipChecker.PermeabilityCheck(shuttle, route);
        string shuttleResult = "Unsuitable engine";
        string avgurMessage = ShipChecker.PermeabilityCheck(avgur, route);
        string avgurResult = "Insufficient engines range";
        Assert.Equal(shuttleResult, shuttleMessage);
        Assert.Equal(avgurResult, avgurMessage);
    }

    [Fact]
    public void SecondCase()
    {
        var vaklas = new Vaklas(false);
        var vaklasWithPhotons = new Vaklas(true);
        var route = new Route();

        int[][] requirements = new int[1][];
        requirements[0] = new[] { 2, 100, 0, 0, 1, 0 };
        route.CreateRoute(1, requirements);

        string vaklasMessage = ShipChecker.PermeabilityCheck(vaklas, route);
        string vaklasResult = "Crew is dead";
        string vaklasWithPhotonsMessage = ShipChecker.PermeabilityCheck(vaklasWithPhotons, route);
        string vaklasWithPhotonsResult = "OK";
        Assert.Equal(vaklasResult, vaklasMessage);
        Assert.Equal(vaklasWithPhotonsResult, vaklasWithPhotonsMessage);
    }

    [Fact]
    public void ThirdCase()
    {
        var vaklas = new Vaklas(false);
        var avgur = new Avgur(false);
        var meredian = new Meredian(false);
        var route = new Route();

        int[][] requirements = new int[1][];
        requirements[0] = new[] { 3, 200, 0, 0, 0, 1 };
        route.CreateRoute(1, requirements);

        string vaklasMessage = ShipChecker.PermeabilityCheck(vaklas, route);
        string vaklasResult = "Ship destroyed";
        ShipChecker.PermeabilityCheck(avgur, route);
        bool avgurResult = false;
        string meredianMessage = ShipChecker.PermeabilityCheck(meredian, route);
        string meredianResult = "OK";
        Assert.Equal(vaklasResult, vaklasMessage);
        Assert.Equal(avgurResult, avgur.IsBroken);
        Assert.Equal(meredianResult, meredianMessage);
    }

    [Fact]
    public void FourthCase()
    {
        var shuttle = new Shuttle(false);
        var vaklas = new Vaklas(false);
        var route = new Route();

        int[][] requirements = new int[1][];
        requirements[0] = new[] { 1, 100, 0, 0, 0, 0 };
        route.CreateRoute(1, requirements);

        string shuttleMessage = ShipChecker.PermeabilityCheck(shuttle, route);
        string shuttleResult = "OK";
        string vaklasMessage = ShipChecker.PermeabilityCheck(vaklas, route);
        string vaklasResult = "OK";
        Assert.Equal(shuttleResult, shuttleMessage);
        Assert.Equal(vaklasResult, vaklasMessage);

        var fuelExchange = new FuelExchange(10, 25);
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
}