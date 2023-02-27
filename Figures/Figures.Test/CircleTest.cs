namespace Figures.Test
{
    public class CircleTests
    {
        private Circle circle;


        private Circle circleMaxRadius;

        [SetUp]
        public void Setup()
        {
            circle = new Circle(10);
            circleMaxRadius = new Circle(ulong.MaxValue);
        }

        /// <summary>
        /// �������� ���������� ������� �����
        /// </summary>
        [Test]
        public void AreaCalculationTest() => Assert.That(circle.GetArea(), Is.EqualTo(Math.PI * Math.Pow(10, 2)));

        /// <summary>
        /// �������� ���������� ���������
        /// </summary>
        [Test]
        public void PerimeterCalculationTest() => Assert.That(circle.GetPerimeter(), Is.EqualTo(2 * Math.PI * 10));

        /// <summary>
        /// �������� ���������� ������� ����� c ������������ ��������� �������
        /// </summary>
        [Test]
        public void AreaMaxCalculationTest() => Assert.That(circleMaxRadius.GetArea(), Is.EqualTo(Math.PI * Math.Pow(ulong.MaxValue, 2)));

        /// <summary>
        /// �������� ���������� ��������� ����� c ������������ ��������� �������
        /// </summary>
        [Test]
        public void PerimeterMaxCalculationTest() => Assert.That(circleMaxRadius.GetPerimeter(), Is.EqualTo(2 * Math.PI * ulong.MaxValue));
    }
}