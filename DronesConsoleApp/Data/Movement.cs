using System;
using System.Collections.Generic;
using System.Text;

namespace DronesConsoleApp.Data
{
    /// <summary>
    /// Dron movement.
    /// - Left: The dron turns left 90º
    /// - Rigth: The dron turns right 90º
    /// - Move: The dron moves fordward one position
    /// </summary>
    public enum Movement
    {
        L, // Left
        R, // Right
        M  // Move
    }
}
