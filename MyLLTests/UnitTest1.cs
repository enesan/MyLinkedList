using Algorithms;

namespace MyLLTests;

[TestClass]
public class MyLinkedListTests
{


    [TestMethod]
    public void CreateWithoutParameters_NotNull()
    {
        var list = new MyLinkedList<int>();
        Assert.IsNotNull(list);
    }

    [TestMethod]
    public void CreateNode_NoError()
    {
        var node = new MyLinkedListNode<int>(1);
        Console.WriteLine(node);
        Assert.IsNotNull(node);
    }

    [TestMethod]
    public void CreateListWithHead_ReturnTrue()
    {
        var list = new MyLinkedList<int>(new MyLinkedListNode<int>(1));
        
        Assert.AreEqual(1, list.Count);
    }
}