public class Student{
    private int _id;
    public int id { get { return _id; } }
    public string givenName { get; set; }
    public string surname { get; set; }
    public const enum status{
        new,
        active,
        dropout,
        graduated
    }
    public status newbie {
        get {

        } set {

        }
    }
    public DateTime startDate{get; set;}
    public DateTime endDate{get; set;}
    public DateTime graduationDate{get; set;}
    
    public Student(int id, string givenName, string surname, DateTime startDate, DateTime endDate, DateTime graduationDate) {
        _id = id;
        this.givenName = givenName;
        this.surname = surname;
        this.startDate = startDate;
        this.endDate = endDate;
        this.graduationDate = graduationDate;
    }


    public string ToString() {
        return id + ", " + givenName + " " + surname + ", " + status + ", " + startDate.ToString("yyyy-MM-dd") + " - " + endDate.ToString("yyyy-MM-dd") + ", Graduation: " + graduationDate.ToString("yyyy-MM-dd");
    }
}