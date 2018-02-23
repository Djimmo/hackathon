namespace BinckChatBot.Contracts
{
    public class INDailyResponse
    {
        public INDaily[] data { get; set; }

        public int page_size { get; set; }
        public int current_page { get; set; }
        public int total_pages { get; set; }
        public int api_call_credits { get; set; }
    }
}
