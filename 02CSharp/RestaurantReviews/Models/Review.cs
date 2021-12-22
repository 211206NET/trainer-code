namespace Models;

public class Review {

    //empty constructor
    public Review() { }

    //Example of constructor overloading
    public Review(int rating)
    {
        this.Rating = rating;
    }

    public Review(int rating, string note)
    {
        this.Rating = rating;
        this.Note = note;
    }

    public int Rating { get; set; }
    public string Note { get; set; }

    //override Review's ToString Method for me here
    //That outputs $"Rating: {review.Rating} \t Note: {review.Note}"

    public override string ToString()
    {
        return $"Rating: {this.Rating} \t Note: {this.Note}";
    }
}