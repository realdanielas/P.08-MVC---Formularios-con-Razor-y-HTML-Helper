namespace P._08_MVC___Formularios_con_Razor_y_HTML_Helper.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
