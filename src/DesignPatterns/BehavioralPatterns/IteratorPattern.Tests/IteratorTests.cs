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
        Assert.Equal(1, sut.GetCurrentItem().GetValue());
        sut.Next();
        Assert.Equal(2, sut.GetCurrentItem().GetValue());
        sut.Next();
        Assert.Equal(3, sut.GetCurrentItem().GetValue());
        Assert.True(sut.IsDone());
    }
}