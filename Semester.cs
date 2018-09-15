using System.Collections.Generic;

/// <summary>
///  Semester with name and sections
/// </summary>
class Semester
{
	private string _name;
	private List<Section> _sections;
    
    /// <summary>
    /// Semester constructor
    /// </summary>
    /// <param name="name">Semeste name</param>
	public Semester(string name) => _name = name;
	
	public string GetName() => _name;

	public void IncludeSection(Section newSection) => _sections.Add(newSection);
}