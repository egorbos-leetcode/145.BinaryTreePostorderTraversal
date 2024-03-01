using BinaryTree;

namespace Solution.Tests;

public class UnitTest
{
    [Fact]
    public void Test()
    {
#pragma warning disable CS8604 // Possible null reference argument.
        Assert.Equal([1, 2, 3], Solution.PostorderTraversal(TreeNode.BuildTree<int>([3, 1, 2]))); 
        Assert.Equal([3, 2, 1], Solution.PostorderTraversal(TreeNode.BuildTree<int>([1, null, 2, 3])));
        Assert.Equal([], Solution.PostorderTraversal(TreeNode.BuildTree<int>([])));
        Assert.Equal([1], Solution.PostorderTraversal(TreeNode.BuildTree<int>([1])));
#pragma warning restore CS8604 // Possible null reference argument.
    }
}