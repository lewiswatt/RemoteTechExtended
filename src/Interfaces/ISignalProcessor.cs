﻿using System;
using UnityEngine;

namespace RemoteTech {
    public interface ISignalProcessor {
        bool Powered { get; }
        Guid Guid { get; }
        Vessel Vessel { get; }
        bool CommandStation { get; }

        bool Master { get; }
        FlightComputer FlightComputer { get; }
        VesselSatellite Satellite { get; }
    }
}
