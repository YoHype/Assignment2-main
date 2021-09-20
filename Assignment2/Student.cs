using System;

public enum Status { New, Active, Dropout, Graduated }

public class Student{
    

    private int _id;
    public int id { get { return _id; } }
    public string givenName { get; set; }
    public string surname { get; set; }
    private Status _status;
    public Status status { get { setStatus(); return _status; } }
    public DateTime startDate{get; set;}
    public DateTime endDate{get; set;}
    public DateTime? graduationDate{get; set;}


    public Student(int id, string givenName, string surname, DateTime startDate, DateTime endDate, DateTime? graduationDate) {
        _id = id;
        this.givenName = givenName;
        this.surname = surname;
        this.startDate = startDate;
        this.endDate = endDate;
        this.graduationDate = graduationDate;
        setStatus();
    }

    private void setStatus() {
        if (startDate > DateTime.Now) _status = Status.New;
        else if (startDate < DateTime.Now && endDate > DateTime.Now) _status = Status.Active;
        else if (endDate < DateTime.Now && graduationDate == null) _status = Status.Dropout;
        else if (graduationDate < DateTime.Now) _status = Status.Graduated;
        else _status = Status.Active;
    }

    public override string ToString() {
        return id + ", " + givenName + " " + surname + ", " + status + ", " + startDate.ToString("dd MMM yyyy") + " - " + endDate.ToString("dd MMM yyyy") + ", Graduation: " + graduationDate?.ToString("dd MMM yyyy");
    }
}