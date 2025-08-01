using Xunit;

namespace IteratorPattern;

public class IteratorTests
{
    [Fact]
    public void ArrayIteratorTests2()
    {
        //arrange
        var array = new MyList(1, 2, 3);
        var iterator = array.CreateIterator();

        //act and assert
        Assert.IsAssignableFrom<Iterable2<int>>(array);
        Assert.IsAssignableFrom<Iterator2<int>>(iterator);

        Assert.Equal(1, iterator.GetCurrentItem());

        iterator.Next();
        Assert.Equal(2, iterator.GetCurrentItem());
        
        iterator.Next();
        Assert.Equal(3, iterator.GetCurrentItem());
        
        Assert.False(iterator.IsDone);
        iterator.Next();
        Assert.True(iterator.IsDone);
    }
    
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