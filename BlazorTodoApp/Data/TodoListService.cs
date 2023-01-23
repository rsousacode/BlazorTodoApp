namespace BlazorTodoApp.Data;

public class TodoListService
{
    public List<EntryData> TodoEntries { get; set; }

    public TodoListService()
    {
        TodoEntries = new List<EntryData>()
        {
            new EntryData
            {
                Id = 0,
                Content = "Dummy content",
                Title = "Do Blazor App"
            },
            new EntryData
            {
                Id = 1,
                Content = "Yet another dummy content",
                Title = "Do a code recipe"
            },

        };
    }

    /// <summary>
    /// Gets To-Do entries
    /// </summary>
    /// <returns>Array containing the entries</returns>
    public List<EntryData> GetEntries()
    {
        // Load from the database
        return TodoEntries.ToList();
    }

    
    public EntryData? GetEntryById(int id)
    {
        return TodoEntries.FirstOrDefault(x => x.Id == id);
    }

    public bool DeleteEntry(int entryId)
    {
        var index = TodoEntries.FindIndex(x => x.Id == entryId);
        if (index != -1)
        {
            TodoEntries.RemoveAt(index);
            return true;
        }

        return false;
    }
}