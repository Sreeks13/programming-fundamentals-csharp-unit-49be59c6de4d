using Xunit;

public class InventoryTests
{
    [Fact]
    public void CheckInventory_ReturnsBooks()
    {
        var result = InventoryChecker.CheckInventory("Book A,Book B");

        Assert.Equal("Book A\nBook B", result.Replace("\r\n", "\n"));
    }

    [Fact]
    public void CheckInventory_HandlesEmptyInput()
    {
        var result = InventoryChecker.CheckInventory("");

        Assert.Equal("Invalid input", result);
    }
}