namespace CollectionTricks.ProblemSet2.Tests
{
    public class TestData
    {
        public static Student[] AllStudents => new Student[]
        {
            new Student { Id = 1, FirstName = "Albert", LastName = "Aaberg", Nationality = Nationality.Danish, BirthDay = new System.DateTime(1805, 06, 20)},
            new Student { Id = 2, FirstName = "Albert", LastName = "Åberg", Nationality = Nationality.Danish, BirthDay = new System.DateTime(1825, 08, 23)},
            new Student { Id = 3, FirstName = "Egil", LastName = "Keller", Nationality = Nationality.Danish, BirthDay = new System.DateTime(1855, 12, 29)},
            new Student { Id = 4, FirstName = "Hanne", LastName = "Keller", Nationality = Nationality.Danish, BirthDay = new System.DateTime(1855, 06, 20)},
            new Student { Id = 5, FirstName = "Charlotte", LastName = "Keller", Nationality = Nationality.Danish, BirthDay = new System.DateTime(1915, 08, 12)},
            new Student { Id = 6, FirstName = "Bengt", LastName = "Keller", Nationality = Nationality.Danish, BirthDay = new System.DateTime(1905, 09, 18)},
            new Student { Id = 7, FirstName = "Berit", LastName = "Keller", Nationality = Nationality.Swedish, BirthDay = new System.DateTime(1905, 08, 23)},
            new Student { Id = 8, FirstName = "Mike", LastName = "Keller", Nationality = Nationality.Swedish, BirthDay = new System.DateTime(1945, 03, 26)},
            new Student { Id = 9, FirstName = "Kristine", LastName = "Karlsen", Nationality = Nationality.Swedish, BirthDay = new System.DateTime(1905, 06, 22)},
            new Student { Id = 10, FirstName = "Tanja", LastName = "Olsen", Nationality = Nationality.Swedish, BirthDay = new System.DateTime(1946, 03, 21)},
            new Student { Id = 11, FirstName = "Ellen", LastName = "Hansen", Nationality = Nationality.Swedish, BirthDay = new System.DateTime(1948, 05, 27)},
            new Student { Id = 12, FirstName = "Kristian", LastName = "Torstein", Nationality = Nationality.Norwegian, BirthDay = new System.DateTime(1945, 06, 14)},
            new Student { Id = 13, FirstName = "Pelle", LastName = "Politibil", Nationality = Nationality.Norwegian, BirthDay = new System.DateTime(2020, 03, 18)},
            new Student { Id = 14, FirstName = "Bønna", LastName = "Hilmarsen", Nationality = Nationality.Norwegian, BirthDay = new System.DateTime(1963, 08, 31)},
            new Student { Id = 15, FirstName = "Ove", LastName = "Oslo", Nationality = Nationality.Norwegian, BirthDay = new System.DateTime(1968, 09, 11)},
            new Student { Id = 16, FirstName = "Ellen", LastName = "Skullerud", Nationality = Nationality.Norwegian, BirthDay = new System.DateTime(1935, 10, 09)},
            new Student { Id = 17, FirstName = "Aud", LastName = "Paulsen", Nationality = Nationality.Norwegian, BirthDay = new System.DateTime(1985, 04, 08)},
            new Student { Id = 18, FirstName = "Janne", LastName = "Gunnarsdottir", Nationality = Nationality.Norwegian, BirthDay = new System.DateTime(1905, 03, 13)},
            new Student { Id = 19, FirstName = "Marit", LastName = "Bjørgen", Nationality = Nationality.Norwegian, BirthDay = new System.DateTime(2000, 02, 24)},
            new Student { Id = 20, FirstName = "Petter", LastName = "Nortug", Nationality = Nationality.Norwegian, BirthDay = new System.DateTime(2001, 01, 23)},
            new Student { Id = 21, FirstName = "Hellen", LastName = "Keller", Nationality = Nationality.Norwegian, BirthDay = new System.DateTime(2031, 01, 29)},
        };

    }
}