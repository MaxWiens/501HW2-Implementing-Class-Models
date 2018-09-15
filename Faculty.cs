using System.Collections.Generic;

/// <summary>
/// Faculty represents a prof. with a name and sections they teach.
/// </summary>
class Faculty : IFaculty
{
	private string _name;
	private List<Section> _sections;

    /// <summary>
    /// Faculty constructor
    /// </summary>
    /// <param name="name">Faculty member name</param>
    public Faculty(string name) => _name = name;

    public string GetName() => _name;
    /// <summary>
    /// Assigns faculty section
    /// </summary>
    /// <param name="assignedSection">section to be assigned</param>
    public void AssignSection(Section assignedSection) => _sections.Add(assignedSection);
}