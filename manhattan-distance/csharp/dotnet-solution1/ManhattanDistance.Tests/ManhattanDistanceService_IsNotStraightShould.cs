using System;
using Xunit;

namespace ManhattanDistance.Tests
{
    public class ManhattanDistanceService_IsNotStraightShould
    {

        private readonly ManhattanDistanceService _manhattanDistanceService;

        public ManhattanDistanceService_IsNotStraightShould()
        {
            _manhattanDistanceService = new ManhattanDistanceService();
        }

        [Fact]
        public void IsManhattanDistance_InputSamePoint_ReturnZero()
        {
            var point_1 = new Point(1, 1);
            var point_2 = new Point(1, 1);
            var result = _manhattanDistanceService.ManhattanDistance(point_1, point_2);

            Assert.Equal(0, result);
        }

        [Fact]
        public void IsManhattanDistance_InputGreaterDiagonal_ReturnBothDistance()
        {
            var point_1 = new Point(2, 2);
            var point_2 = new Point(1, 1);
            var result = _manhattanDistanceService.ManhattanDistance(point_1, point_2);

            Assert.Equal(2, result);
        }

        [Fact]
        public void IsManhattanDistance_InputLessThanDiagonal_ReturnBothDistance()
        {
            var point_1 = new Point(-4, -4);
            var point_2 = new Point(1, 1);
            var result = _manhattanDistanceService.ManhattanDistance(point_1, point_2);

            Assert.Equal(10, result);
        }


        [Fact]
        public void IsManhattanDistance_InputNotSameVerticalDistance_ReturnBothDistance()
        {
            var point_1 = new Point(-4, -6);
            var point_2 = new Point(1, 1);
            var result = _manhattanDistanceService.ManhattanDistance(point_1, point_2);

            Assert.Equal(12, result);
        }

        [Fact]
        public void IsManhattanDistance_InputNotSameHorizontalDistance_ReturnBothDistance()
        {
            var point_1 = new Point(-6, -4);
            var point_2 = new Point(1, 1);
            var result = _manhattanDistanceService.ManhattanDistance(point_1, point_2);

            Assert.Equal(12, result);
        }
    }
}
