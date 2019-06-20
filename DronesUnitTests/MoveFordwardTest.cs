using DronesConsoleApp;
using DronesConsoleApp.Business;
using DronesConsoleApp.Data;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    public class MoveFordwardTest
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
        /// Test that dron oriented to north moves fordward one position through Y axis.
        /// </summary>
        [Test]
        public void DronNorthMoveFordward()
        {
            dronsToMove.Clear();
            movements.Clear();

            dron = new Dron(flyingArea, 3, 4, Direction.N);

            Movement movement = Movement.M;
            movements.Add(movement);

            DronInit dronToMove = new DronInit(dron, movements);
            dronsToMove.Add(dronToMove);

            Program.MoveAllDrones(dronsToMove);

            Assert.AreEqual(3, dron.XPosition);
            Assert.AreEqual(5, dron.YPosition);
            Assert.AreEqual(Direction.N, dron.Direction);
        }

        /// <summary>
        /// Test that dron oriented to north doesn't move if it goes out of flying area.
        /// </summary>
        [Test]
        public void DronNorthMoveFordwardOutFlyingArea()
        {
            dronsToMove.Clear();
            movements.Clear();

            dron = new Dron(flyingArea, 3, 6, Direction.N);

            Movement movement = Movement.M;
            movements.Add(movement);

            DronInit dronToMove = new DronInit(dron, movements);
            dronsToMove.Add(dronToMove);

            Program.MoveAllDrones(dronsToMove);

            Assert.AreEqual(3, dron.XPosition);
            Assert.AreEqual(6, dron.YPosition);
            Assert.AreEqual(Direction.N, dron.Direction);
        }

        /// <summary>
        /// Test that dron oriented to south moves fordward one position through Y axis.
        /// </summary>
        [Test]
        public void DronSouthhMoveFordward()
        {
            dronsToMove.Clear();
            movements.Clear();

            dron = new Dron(flyingArea, 3, 4, Direction.S);

            Movement movement = Movement.M;
            movements.Add(movement);

            DronInit dronToMove = new DronInit(dron, movements);
            dronsToMove.Add(dronToMove);

            Program.MoveAllDrones(dronsToMove);

            Assert.AreEqual(3, dron.XPosition);
            Assert.AreEqual(3, dron.YPosition);
            Assert.AreEqual(Direction.S, dron.Direction);
        }

        /// <summary>
        /// Test that dron oriented to south doesn't move if it goes out of flying area.
        /// </summary>
        [Test]
        public void DronSouthMoveFordwardOutFlyingArea()
        {
            dronsToMove.Clear();
            movements.Clear();

            dron = new Dron(flyingArea, 3, 0, Direction.S);

            Movement movement = Movement.M;
            movements.Add(movement);

            DronInit dronToMove = new DronInit(dron, movements);
            dronsToMove.Add(dronToMove);

            Program.MoveAllDrones(dronsToMove);

            Assert.AreEqual(3, dron.XPosition);
            Assert.AreEqual(0, dron.YPosition);
            Assert.AreEqual(Direction.S, dron.Direction);
        }

        /// <summary>
        /// Test that dron oriented to east moves fordward one position through X axis.
        /// </summary>
        [Test]
        public void DronEastMoveFordward()
        {
            dronsToMove.Clear();
            movements.Clear();

            dron = new Dron(flyingArea, 3, 4, Direction.E);

            Movement movement = Movement.M;
            movements.Add(movement);

            DronInit dronToMove = new DronInit(dron, movements);
            dronsToMove.Add(dronToMove);

            Program.MoveAllDrones(dronsToMove);

            Assert.AreEqual(4, dron.XPosition);
            Assert.AreEqual(4, dron.YPosition);
            Assert.AreEqual(Direction.E, dron.Direction);
        }

        /// <summary>
        /// Test that dron oriented to east doesn't move if it goes out of flying area.
        /// </summary>
        [Test]
        public void DronEastMoveFordwardOutFlyingArea()
        {
            dronsToMove.Clear();
            movements.Clear();

            dron = new Dron(flyingArea, 6, 4, Direction.E);

            Movement movement = Movement.M;
            movements.Add(movement);

            DronInit dronToMove = new DronInit(dron, movements);
            dronsToMove.Add(dronToMove);

            Program.MoveAllDrones(dronsToMove);

            Assert.AreEqual(6, dron.XPosition);
            Assert.AreEqual(4, dron.YPosition);
            Assert.AreEqual(Direction.E, dron.Direction);
        }

        /// <summary>
        /// Test that dron oriented to west moves fordward one position through X axis.
        /// </summary>
        [Test]
        public void DronWestMoveFordward()
        {
            dronsToMove.Clear();
            movements.Clear();

            dron = new Dron(flyingArea, 3, 4, Direction.W);

            Movement movement = Movement.M;
            movements.Add(movement);

            DronInit dronToMove = new DronInit(dron, movements);
            dronsToMove.Add(dronToMove);

            Program.MoveAllDrones(dronsToMove);

            Assert.AreEqual(2, dron.XPosition);
            Assert.AreEqual(4, dron.YPosition);
            Assert.AreEqual(Direction.W, dron.Direction);
        }

        /// <summary>
        /// Test that dron oriented to west doesn't move if it goes out of flying area.
        /// </summary>
        [Test]
        public void DronWestMoveFordwardOutFlyingArea()
        {
            dronsToMove.Clear();
            movements.Clear();

            dron = new Dron(flyingArea, 0, 4, Direction.W);

            Movement movement = Movement.M;
            movements.Add(movement);

            DronInit dronToMove = new DronInit(dron, movements);
            dronsToMove.Add(dronToMove);

            Program.MoveAllDrones(dronsToMove);

            Assert.AreEqual(0, dron.XPosition);
            Assert.AreEqual(4, dron.YPosition);
            Assert.AreEqual(Direction.W, dron.Direction);
        }
    }
}