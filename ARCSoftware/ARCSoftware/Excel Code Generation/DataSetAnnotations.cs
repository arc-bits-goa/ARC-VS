 

using System;

class DisplayColumnAttribute : Attribute
{
    public string DisplayName { get; set; }
    public uint DisplayOrder { get; set; }

    public DisplayColumnAttribute(string displayName, uint displayOrder = 0)
    {
        DisplayName = displayName;
        DisplayOrder = displayOrder;
    }
}

class DisplayTableAttribute : Attribute
{
    public string Display { get; set; }

    public DisplayTableAttribute(string display)
    {
        Display = display;
    }
}
