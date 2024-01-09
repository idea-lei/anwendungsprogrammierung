namespace apiProjekt.DataModel
{
    public class Exam
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double MaxPunkte { get; set; }
    }

    public class ExamOfStudent
    {
        public string Id { get; set; }
        public string ExamId { get; set; }
        public string StudentId { get; set; }
        public double Punkte { get; set; }
        // ...
    }

}
