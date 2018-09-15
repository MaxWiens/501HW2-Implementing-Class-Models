/// <summary>
/// OnCampus section
/// </summary>
class OnCampus : Section
{
    /// <summary>
    /// Oncampus constructor
    /// </summary>
    /// <param name="semester">section semester</param>
    /// <param name="course">section course</param>
    /// <param name="teacher">section facultyr</param>
    /// <param name="number">section number</param>
    /// <param name="cap">section cap</param>
	public OnCampus(Semester semester, Course course, Faculty teacher, string number, int cap)
	{
        _semester = semester;
        _course = course;
        _faculty = teacher;
        _number = number;
        _cap = cap;
    }

    public override string ToString()
    {
        return _course.Number + " section " + _number + " (" + _course.Title + ") " + _course + " is being taught by " + _faculty.GetName() + " in " + _semester.GetName();
    }
}