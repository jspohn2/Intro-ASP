namespace BasicMVC.Models{
    public class Message
    {
        private int v1;
        private string v2;

        public int MessageID { get; set; }
        public string MessageText { get; set; } = string.Empty;
    }
}