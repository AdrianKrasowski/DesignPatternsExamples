using DesignPatternsExamples.Creational.Singleton;
using Xunit;

namespace DesignPatternsTests.Creational.Sigleton
{
    public class SingletonClassTest
    {
        [Fact]
        public void SingletonClass_GetInstance_ShouldAlwaysReturnTheSameObject()
        {
            //Arrange 
            var _uut = SingletonClass.GetInstance();

            //Act
            var secondInstance = SingletonClass.GetInstance();

            //Assert
            Assert.Equal(secondInstance, _uut);
        }
    }
}
