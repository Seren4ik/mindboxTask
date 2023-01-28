using FigureArea;

namespace TestFiguresProject
{
    public class Tests
    {
        [Test]
        public void TestAreaÑircle()
        {
            var figure = new Model(10).circle;
            Assert.That(Math.Round(figure !=null ? figure.Area:0, 0), Is.EqualTo(314));
        }

        [Test]
        public void TestAreaÑircleNotType()
        {
            var figure = new Model(10);
            Assert.That(Math.Round(figure != null ? figure.area : 0, 0), Is.EqualTo(314));
        }

        [Test]
        public void TestAreaTriangle()
        {
            var figure = new Model(10,10,10).triangle;
            Assert.That(Math.Round(figure != null ? figure.Area : 0, 1), Is.EqualTo(43.3));
        }

        [Test]
        public void TestTypeÑircle()
        {
            var figure = new Model(10);
            Assert.That(figure != null ? figure.typeFigure : "íå îïğåäåëåí", Is.EqualTo("Êğóã"));
        }

        [Test]
        public void TestTypeTriangle()
        {
            var figure = new Model(10, 10, 10);
            Assert.That(figure != null ? figure.typeFigure : "íå îïğåäåëåí", Is.EqualTo("Òğåóãîëüíèê"));
        }


        [Test]
        public void TestCheckRectangularTrue()
        {
            var figure = new Model(6,8,10).triangle;
            Assert.That(figure != null ? figure.CheckRectangular(): false, Is.EqualTo(true));
        }

        [Test]
        public void TestCheckRectangularFalse()
        {
            var figure = new Model(6, 8, 9).triangle;
            Assert.That(figure != null ? figure.CheckRectangular() : true, Is.EqualTo(false));
        }
    }
}