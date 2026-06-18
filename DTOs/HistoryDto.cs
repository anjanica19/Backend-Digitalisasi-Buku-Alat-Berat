namespace astratech_apps_backend.DTOs {
    public class HistorySummaryDto
    {
        public int IdHistory { get; set; }
        public string? Code { get; set; }
        public string Title { get; set; } = string.Empty;
        public int TotalSearch { get; set; }
    }

    public class HistoryDetailDto
    {
        public string Nim { get; set; } = string.Empty;
        public string NamaMahasiswa { get; set; } = string.Empty;
        public int TotalSearch { get; set; }
        public DateTime FirstSearch { get; set; }
        public DateTime LastSearch { get; set; }
    }
}