using System;
using System.Collections.Generic;
using System.Linq;

public static class InventoryChecker
{
    public static string CheckInventory(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return "Invalid input";

        var books = input
            .Split(',', StringSplitOptions.RemoveEmptyEntries)
            .Select(book => book.Trim())
            .Where(book => !string.IsNullOrWhiteSpace(book))
            .ToList();

        if (books.Count == 0)
            return "No books";

        return string.Join(Environment.NewLine, books);
    }
}