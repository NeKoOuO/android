﻿namespace ShortDev.Microsoft.ConnectedDevices.Protocol.Platforms;

public sealed class CdpBluetoothDevice : ICdpDevice
{
    public string? Name { get; init; }
    public string? Alias { get; init; }
    public string? Address { get; init; }

    public byte[]? BeaconData { get; init; }
}