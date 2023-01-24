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
    /// Adds a To-Do entry to TodoEntries list.
    /// </summary>
    /// <param name="entry">Entry to add</param>
    public EntryData AddEntry(EntryDataDto entry)
    {
        // Create new entry
        var newEntry = new EntryData()
        {
            Id = TodoEntries.Count,
            Content = entry.Content,
            Title = entry.Title
        };
    
        TodoEntries.Add(newEntry);
        return newEntry;
    }
    /// <summary>
    /// Updates a To-do entry
    /// </summary>
    /// <param name="entryId">Id of the entry.</param>
    /// <param name="updatedData">The data to update</param>
    /// <returns></returns>
    public bool UpdateEntry(int entryId, EntryDataDto dataDto)
    {
        var index = TodoEntries.FindIndex(x => x.Id == entryId);
        if (index != -1)
        {
            TodoEntries[index].Content = dataDto.Content;
            TodoEntries[index].Title = dataDto.Title;
            return true;
        }

        return false;
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