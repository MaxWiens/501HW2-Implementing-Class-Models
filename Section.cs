
abstract class Section
{
    public string _number;
    public int _cap;

    protected Semester _semester;
    protected IFaculty _faculty;
    protected Course _course;

    public void SetNumber(string number) => _number = number;
    public string GetNumber() => _number;
    public void SetCap(int cap) => _cap = cap;
    public int GetCap() => _cap;
}
