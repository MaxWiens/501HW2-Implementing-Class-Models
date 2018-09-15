using System.Collections.Generic;

class Semester
{
	private string name;
	private List<Section> _sections;

	public Semester(string name)
	{
		this.name = name;
	}
	
	public string GetName()
	{
		return name;
	}

	public IncludeSection(Section newSection)
	{
		_sections.Add(newSection);
	}
}