using System.Collections;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Entities.Repositories;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Services;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Services.Builder;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab2.Tests;

public class SecondLabTests
{
    [Theory]
    [MemberData(nameof(TestDataGenerator.GetData), MemberType = typeof(TestDataGenerator))]
    public void OneHundredPercentSuccessfulBuild(
        string processorName,
        string motherboardName,
        string ramName,
        string gpuName,
        string airCoolerName,
        string powerSupplyName,
        string storageName,
        string pcCaseName,
        CheckerMessages expected)
    {
        var repository = new Repository();
        IPcComponent? processor = repository.GetComponent(processorName);
        IPcComponent? motherboard = repository.GetComponent(motherboardName);
        IPcComponent? ram = repository.GetComponent(ramName);
        IPcComponent? gpu = repository.GetComponent(gpuName);
        IPcComponent? airCooler = repository.GetComponent(airCoolerName);
        IPcComponent? powerSupply = repository.GetComponent(powerSupplyName);
        IPcComponent? storage = repository.GetComponent(storageName);
        IPcComponent? pcCase = repository.GetComponent(pcCaseName);
        var builder = new PersonalComputerBuilder();
        if (motherboard is null || processor is null || ram is null
            || gpu is null || airCooler is null || powerSupply is null
            || storage is null || pcCase is null) return;
        PersonalComputer personalComputer = builder.WithPcCase(pcCase)
            .WithMotherBoard(motherboard)
            .WithProcessor(processor)
            .WithRam(ram)
            .WithVideoCard(gpu)
            .WithCoolingSystem(airCooler)
            .WithStorage(storage)
            .WithPowerSupply(powerSupply)
            .Build();

        var checker = new Checker(personalComputer);
        CheckerMessages actual = checker.Check();

        Assert.Equal(expected, actual);
    }

    private class TestDataGenerator : IEnumerable<object[]>
    {
        private const string ProcessorName = "Ryzen 5 5600";
        private const string SecondProcessorName = "Intel Core I5-12400F";
        private const string MotherBoardName = "MSI B450 Gaming Plus Max";
        private const string RamName = "G.Skill TRIDENT Z5";
        private const string GpuName = "MSI GeForce RTX 4060 Gaming X";
        private const string AirCoolerName = "Be quite! Pure Rock 2";
        private const string SecondAirCoolerName = "Cooler with low tdp";
        private const string PowerSupplyName = "Be quite! Pure Power 11";
        private const string StorageName = "Kingston A400";
        private const string SecondPowerSupplyName = "KCAS";
        private const string PcCase = "LIAN LI Lancool 205 Mesh White";
        private static CheckerMessages FirstTestMessage => CheckerMessages.Success;
        private static CheckerMessages SecondTestMessage => CheckerMessages.InsufficientPowerSupplyCapacity;
        private static CheckerMessages ThirdTestMessage => CheckerMessages.DisclaimerOfWarrantyLiability;
        private static CheckerMessages FourthTestMessage => CheckerMessages.UnsupportableSocket;

        public static IEnumerable<object[]> GetData()
        {
            yield return new object[]
            {
                ProcessorName,
                MotherBoardName,
                RamName,
                GpuName,
                AirCoolerName,
                PowerSupplyName,
                StorageName,
                PcCase,
                FirstTestMessage,
            };
            yield return new object[]
            {
                ProcessorName,
                MotherBoardName,
                RamName,
                GpuName,
                AirCoolerName,
                SecondPowerSupplyName,
                StorageName,
                PcCase,
                SecondTestMessage,
            };
            yield return new object[]
            {
                ProcessorName,
                MotherBoardName,
                RamName,
                GpuName,
                SecondAirCoolerName,
                PowerSupplyName,
                StorageName,
                PcCase,
                ThirdTestMessage,
            };
            yield return new object[]
            {
                SecondProcessorName,
                MotherBoardName,
                RamName,
                GpuName,
                AirCoolerName,
                PowerSupplyName,
                StorageName,
                PcCase,
                FourthTestMessage,
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