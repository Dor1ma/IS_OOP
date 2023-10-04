namespace Itmo.ObjectOrientedProgramming.Lab1.Ships;

public static class ShipParameters
{
    public static double LowMass => 1.1;
    public static double MediumMass => 1.3;
    public static double HighMass => 1.5;
    public static int FirstDeflectorsAsteroidsLimit => 2;
    public static int FirstDeflectorsMeteorsLimit => 1;
    public static int SecondDeflectorsAsteroidsLimit => 10;
    public static int SecondDeflectorsMeteorsLimit => 3;
    public static int ThirdDeflectorsAsteroidsLimit => 40;
    public static int ThirdDeflectorsMeteorsLimit => 10;
    public static int ThirdDeflectorsWhalesLimit => 1;
    public static int ArmorClassOneAsteroidsLimit => 1;
    public static int ArmorClassOneMeteorsLimit => 0;
    public static int ArmorClassTwoAsteroidsLimit => 5;
    public static int ArmorClassTwoMeteorsLimit => 2;
    public static int ArmorClassThreeAsteroidsLimit => 20;
    public static int ArmorClassThreeMeteorsLimit => 5;
    public static int PhotonDeflectorLimit => 3;
    public static bool NoAntiNitriniumEmitter => false;
    public static bool WithAntiNitriniumEmitter => true;
    public static int ImpulseEngineTypeCStartCost => 10;
    public static double ImpulseEngineTypeCSpeed => 150;
    public static int ImpulseEngineTypeEStartCost => 25;
    public static int JumpEngineTypeAlphaRange => 100;
    public static int JumpEngineTypeOmegaRange => 500;
    public static int JumpEngineTypeGammaRange => 1000;
}