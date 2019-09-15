using Xunit;

namespace ManhattanDistance.Tests
{
    public class ManhattanDistanceService_IsHorizontalShould
    {

        private readonly ManhattanDistanceService _manhattanDistanceService;

        public ManhattanDistanceService_IsHorizontalShould()
        {
            _manhattanDistanceService = new ManhattanDistanceService();
        }

        [Fact]
        public void IsManhattanDistance_InputGreater_ReturnOneOrMore()
        {
            var point_1 = new Point(1, 1);
            var point_2 = new Point(2, 1);
            var result = _manhattanDistanceService.ManhattanDistance(point_1, point_2);

            Assert.Equal(1, result);
        }

        [Fact]
        public void IsManhattanDistance_InputLessThan_ReturnOneOrMore()
        {
            var point_1 = new Point(1, 1);
            var point_2 = new Point(-2, 1);
            var result = _manhattanDistanceService.ManhattanDistance(point_1, point_2);

            Assert.Equal(3, result);
        }
    }
}
