using DronesConsoleApp;
using DronesConsoleApp.Business;
using DronesConsoleApp.Data;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    public class ChangePositionTest
    {
        // Flying Area
        private FlyingArea flyingArea;        

        // List of drones and movements
        private List<DronInit> dronsToMove = new List<DronInit>();

        // Especific dron
        private Dron dron;

        // Movements for specific dron
        private List<Movement> movements = new List<Movement>();
        
        [SetUp]
        public void Setup()
        {
            // Define flying area for testing purpose
            flyingArea = new FlyingArea(6, 6);            
        }

        /// <summary>
        /// Test that dron oriented to north turns left.
        /// </summary>
        [Test]
        public void DronNorthTurnLeft()
        {            
            dronsToMove.Clear();
            movements.Clear();
            
            dron = new Dron(flyingArea, 5, 5, Direction.N);
           
            Movement movement = Movement.L;            
            movements.Add(movement);

            DronInit dronToMove = new DronInit(dron, movements);
            dronsToMove.Add(dronToMove);

            Program.MoveAllDrones(dronsToMove);

            Assert.AreEqual(Direction.W, dron.Direction);
        }

        /// <summary>
        /// Test that dron oriented to north turns right.
        /// </summary>
        [Test]
        public void DronNorthTurnRight()
        {
            dronsToMove.Clear();
            movements.Clear();

            dron = new Dron(flyingArea, 5, 5, Direction.N);

            Movement movement = Movement.R;
            movements.Add(movement);

            DronInit dronToMove = new DronInit(dron, movements);
            dronsToMove.Add(dronToMove);

            Program.MoveAllDrones(dronsToMove);

            Assert.AreEqual(Direction.E, dron.Direction);
        }

        /// <summary>
        /// Test that dron oriented to south turns left.
        /// </summary>
        [Test]
        public void DronSouthTurnLeft()
        {
            dronsToMove.Clear();
            movements.Clear();

            dron = new Dron(flyingArea, 5, 5, Direction.S);

            Movement movement = Movement.L;
            movements.Add(movement);

            DronInit dronToMove = new DronInit(dron, movements);
            dronsToMove.Add(dronToMove);

            Program.MoveAllDrones(dronsToMove);

            Assert.AreEqual(Direction.E, dron.Direction);
        }

        /// <summary>
        /// Test that dron oriented to south turns right.
        /// </summary>
        [Test]
        public void DronSouthTurnRight()
        {
            dronsToMove.Clear();
            movements.Clear();

            dron = new Dron(flyingArea, 5, 5, Direction.S);

            Movement movement = Movement.R;
            movements.Add(movement);

            DronInit dronToMove = new DronInit(dron, movements);
            dronsToMove.Add(dronToMove);

            Program.MoveAllDrones(dronsToMove);

            Assert.AreEqual(Direction.W, dron.Direction);
        }

        /// <summary>
        /// Test that dron oriented to east turns left.
        /// </summary>
        [Test]
        public void DronEastTurnLeft()
        {
            dronsToMove.Clear();
            movements.Clear();

            dron = new Dron(flyingArea, 5, 5, Direction.E);

            Movement movement = Movement.L;
            movements.Add(movement);

            DronInit dronToMove = new DronInit(dron, movements);
            dronsToMove.Add(dronToMove);

            Program.MoveAllDrones(dronsToMove);

            Assert.AreEqual(Direction.N, dron.Direction);
        }

        /// <summary>
        /// Test that dron oriented to east turns right.
        /// </summary>
        [Test]
        public void DronEastTurnRight()
        {
            dronsToMove.Clear();
            movements.Clear();

            dron = new Dron(flyingArea, 5, 5, Direction.E);

            Movement movement = Movement.R;
            movements.Add(movement);

            DronInit dronToMove = new DronInit(dron, movements);
            dronsToMove.Add(dronToMove);

            Program.MoveAllDrones(dronsToMove);

            Assert.AreEqual(Direction.S, dron.Direction);
        }

        /// <summary>
        /// Test that dron oriented to west turns left.
        /// </summary>
        [Test]
        public void DronWestTurnLeft()
        {
            dronsToMove.Clear();
            movements.Clear();

            dron = new Dron(flyingArea, 5, 5, Direction.W);

            Movement movement = Movement.L;
            movements.Add(movement);

            DronInit dronToMove = new DronInit(dron, movements);
            dronsToMove.Add(dronToMove);

            Program.MoveAllDrones(dronsToMove);

            Assert.AreEqual(Direction.S, dron.Direction);
        }

        /// <summary>
        /// Test that dron oriented to west turns right.
        /// </summary>
        [Test]
        public void DronWestTurnRight()
        {
            dronsToMove.Clear();
            movements.Clear();

            dron = new Dron(flyingArea, 5, 5, Direction.W);

            Movement movement = Movement.R;
            movements.Add(movement);

            DronInit dronToMove = new DronInit(dron, movements);
            dronsToMove.Add(dronToMove);

            Program.MoveAllDrones(dronsToMove);

            Assert.AreEqual(Direction.N, dron.Direction);
        }
    }
}