namespace DrinksApp.Models
{
    internal interface IHttpContextAssessor
    {
        object HttpContext { get; }
    }
}