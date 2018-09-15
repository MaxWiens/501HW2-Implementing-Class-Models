
class OnCampus : Section
{

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