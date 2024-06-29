namespace MyCalculatorApp.web.Models;



public class ErrorViewModel
    {
        public required string RequestId { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
public class CalculatorModel
{
    public string? RequestId { get; set; }

    public int Value1 { get; set; }
    public int Value2 { get; set; }

    public double Result { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
