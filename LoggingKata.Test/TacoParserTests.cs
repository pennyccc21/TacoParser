using System;
using System.Collections.Generic;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        private IEnumerable<object> expected;

        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.Equal(expected, (IEnumerable<object>)actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            var TacoParseInstance = new TacoParser();


            //Act
            var actual = TacoParseInstance.Parse(line).Location.Longitude;

            //Assert
              Assert.Equal(expected, actual);
        }


        //TODO: Create a test ShouldParseLatitude

    }
}
