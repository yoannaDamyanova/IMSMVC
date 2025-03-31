using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace FitnessApp.Web.ViewModels.Attributes
{
    public class CountAttribute : ValidationAttribute
    {
        private readonly string _count;

        public CountAttribute(string count)
            : base("Броят, който сте избрали не е валиден")
        {
            _count = count;
        }
    }
}
