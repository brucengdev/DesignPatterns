using Shouldly;

namespace IteratorPattern.Tests;

public class IteratorTests
{
    [Fact]
    public void ArrayIteratorTests()
    {
        //arrange
        Iterable<int>[] myArray = new []{ 1, 2, 3 }
            .Select(v => new Iterable<int>(v)).ToArray();
        var sut = new Iterator<int>(myArray);
        
        //act
        sut.First();
        
        //assert
        sut.GetCurrentItem().GetValue().ShouldBe(1);
        sut.Next();
        sut.GetCurrentItem().GetValue().ShouldBe(2);
        sut.Next();
        sut.GetCurrentItem().GetValue().ShouldBe(3);
        sut.IsDone().ShouldBeTrue();
    }
}