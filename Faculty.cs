class Faculty : IFaculty
{
	private string name;
	private List<Section> _sections;

	public string GetName()
	{
		return name;
	}
	
	public AssignSection(Section assignedSection)
	{
		_sections.Add(assignedSection)
	}
}