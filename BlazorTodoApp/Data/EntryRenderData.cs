namespace BlazorTodoApp.Data;

public class EntryRenderData
{
    public bool IsCollapsed { get; set; } = true;
    public bool IsEditMode { get; set; } = false;
    public bool IsCreateMode { get; set; } = false;
    public EntryData Data { get; set; }

    public EntryRenderData(EntryData data)
    {
        Data = data;
    }
}
