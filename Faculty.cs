using System.Collections.Generic;

class Faculty : IFaculty
{
	private string name;
	private List<Section> _sections;

    public Faculty(string s) => name = s;

	public string GetName() => name;
	public void AssignSection(Section assignedSection) => _sections.Add(assignedSection);
}