using System.Collections.Generic;

class Semester
{
	private string _name;
	private List<Section> _sections;

	public Semester(string name) => _name = name;
	
	public string GetName() => _name;

	public void IncludeSection(Section newSection) => _sections.Add(newSection);
}