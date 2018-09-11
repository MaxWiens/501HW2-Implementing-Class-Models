abstract class OnCampus
{
	public string _number;
	public int _cap;
	private Semester _sections;
	private IFaculty _faculty;
	private Course _course;
	public void SetNumber(string number);
	public string GetNumber();
	public void SetCap(int cap);
	public int GetCap();
}