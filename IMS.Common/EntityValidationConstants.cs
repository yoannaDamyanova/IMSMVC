namespace IMS.Common
{
    public class EntityValidationConstants
    {
        public const string DateFormat = "dd/MM/yyyy HH:mm";
        public static class Product
        {
            public const int MaxTitleLength = 50;
            public const int MinTitleLength = 3;
            public const int MaxDescriptionLength = 500;
            public const int MinDescriptionLength = 10;
            public const int MinCount = 1;
            public const int MaxCount = 1000;
            public const double MinPrice = 0.01;
            public const double MaxPrice = 100000.00;
        }

        public static class Category
        {
            public const int MaxNameLength = 100;
            public const int MinNameLength = 5;
        }

        public static class User
        {
            public const int MaxNameLength = 100;
            public const int MinNameLength = 2;
        }

        public static class Employee
        {
            public const int MaxYOFLength = 40;
            public const int MinYOFLength = 0;
        }
    }
}
