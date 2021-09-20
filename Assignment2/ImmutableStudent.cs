using System;

public record ImmutableStudent {
    public int id { get; init; }
    public string givenName { get; init; }
    public string surname { get; init; }
    public Status status { get; init; }
    public DateTime startDate{get; init;}
    public DateTime endDate{get; init;}
    public DateTime? graduationDate{get; init;}

    public ImmutableStudent(int id, string givenName, string surname, DateTime startDate, DateTime endDate, DateTime? graduationDate) {
        this.id = id;
        this.givenName = givenName;
        this.surname = surname;
        this.startDate = startDate;
        this.endDate = endDate;
        this.graduationDate = graduationDate;

        if (startDate > DateTime.Now) status = Status.New;
        else if (startDate < DateTime.Now && endDate > DateTime.Now) status = Status.Active;
        else if (endDate < DateTime.Now && graduationDate == null) status = Status.Dropout;
        else if (graduationDate < DateTime.Now) status = Status.Graduated;
        else status = Status.Active;
    }
}