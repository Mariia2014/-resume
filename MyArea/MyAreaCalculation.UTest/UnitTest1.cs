using System;
using Xunit;

namespace MyAreaCalculation.UTest
{
    public class UnitTest1
    {
        [Fact]
        public void RangeAreaWIthoutValues()
        {
            //arrange
            MyAreaCalculation.Shapes.Range circle = new MyAreaCalculation.Shapes.Range();
            //act
            var area = circle.Area;
            //assert
            Assert.Equal(0, area);
        }
        [Fact]
        public void RangeAreaWIthValues()
            {
            //arrange
            MyAreaCalculation.Shapes.Range circle = new MyAreaCalculation.Shapes.Range(6);
                var correctArea = Math.PI * Math.Pow(6, 2);
                //act
                var area = circle.Area;

                //assert
                Assert.Equal(correctArea, area);
            }
        [Fact]
        public void TrigonleAreaWIthValues()
        {
            //arrange
            MyAreaCalculation.Shapes.Trigon triangle = new MyAreaCalculation.Shapes.Trigon(3, 4, 5);

            //act
            var area = triangle.Area;

            //assert
            Assert.Equal(6, area);
        }
        [Fact]
        public void TrigonIsRight()
        {
            //arrange
            MyAreaCalculation.Shapes.Trigon triangle = new MyAreaCalculation.Shapes.Trigon(3, 4, 5);

            //act
            bool isRight = triangle.IsRightTriangle();

            //assert
            Assert.True(isRight);
        }
        [Fact]
        public void AreaOfShape()
        {
            //arrange
            MyAreaCalculation.Shapes.Shape shape = new MyAreaCalculation.Shapes.Shape(new Shapes.Range());

            //act
            var area = shape.Area;

            //assert
            Assert.Equal(0, area);
        }
    }
    }

