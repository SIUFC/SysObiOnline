namespace SysObiOnline.DTOS
{
    public class QuizSummaryDTO
    {
        public int TotalQuestions { get; set; }
        public int TotalCorrect { get; set; }
        public int TotalIncorrect { get; set; }
        public int Level1Count { get; set; }
        public int Level2Count { get; set; }
        public int Level3Count { get; set; }
        public string Message { get; set; }
    }
}
