using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.CoolingSystems;

public class Cooler : IPcComponent
{
    public Cooler(string name, int height, int maximumTdp, ICollection<Processor> supportableSockets, int powerConsumption)
    {
        Name = name;
        Height = height;
        MaximumTdp = maximumTdp;
        SupportableSockets = supportableSockets;
        PowerConsumption = powerConsumption;
    }

    public string Name { get; private set; }
    public int Height { get; private set; }
    public int MaximumTdp { get; private set; }
    public ICollection<Processor> SupportableSockets { get; private set; }
    public int PowerConsumption { get; private set; }

    public Cooler Clone()
    {
        return new Cooler((string)Name.Clone(), Height, MaximumTdp, SupportableSockets, PowerConsumption);
    }

    public Cooler ChangeName(string newName)
    {
        Cooler clone = Clone();
        clone.Name = newName;
        return clone;
    }

    public Cooler ChangeHeight(int newHeight)
    {
        Cooler clone = Clone();
        clone.Height = newHeight;
        return clone;
    }

    public Cooler ChangeMaximumTdp(int newMaximumTdp)
    {
        Cooler clone = Clone();
        clone.MaximumTdp = newMaximumTdp;
        return clone;
    }

    public Cooler ChangeSupportableSockets(ICollection<Processor> newSupportableSockets)
    {
        Cooler clone = Clone();
        clone.SupportableSockets = newSupportableSockets;
        return clone;
    }

    public Cooler ChangePowerConsumption(int powerConsumption)
    {
        Cooler clone = Clone();
        clone.PowerConsumption = powerConsumption;
        return clone;
    }

    public bool CheckSupportability(Processor socket)
    {
        foreach (Processor supportableSocket in SupportableSockets)
        {
            if (supportableSocket.Equals(socket))
            {
                return true;
            }
        }

        return false;
    }
}