﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficSelection {
    public static class Extensions {
        public static string GetName(this StationComponent station) {
            if (!string.IsNullOrEmpty(station.name)) {
                return station.name;
            }
            if (station.isCollector) {
                return String.Format("Orbital Collector #{0}", station.gid);
            } else if (station.isStellar) {
                if (station.storage.Length > 5) {
                    return String.Format("Interstellar Giga Station #{0}", station.gid);
                } else {
                    return String.Format("Interstellar Station #{0}", station.gid);
                }
            } else {
                if (station.storage.Length > 3) {
                    return String.Format("Planetary Giga Station #{0}", station.id);
                } else {
                    return String.Format("Local Station #{0}", station.id);
                }
            }
        }
    }
}