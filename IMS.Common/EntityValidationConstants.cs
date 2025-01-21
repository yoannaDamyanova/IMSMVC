﻿namespace IMS.Common
{
    public class EntityValidationConstants
    {
        public const string DateFormat = "dd/MM/yyyy HH:mm";
        public static class Product
        {
            public const int MinDurationMinutes = 30;
            public const int MaxDurationMinutes = 180;
            public const int MaxTitleLength = 50;
            public const int MinTitleLength = 3;
            public const int MaxDescriptionLength = 500;
            public const int MinDescriptionLength = 10;
            public const int MinCount = 1;
            public const int MaxCount = 1000;
            public const double MinPrice = 0.01;
            public const double MaxPrice = 100000.00;
        }

        public static class Review
        {
            public const int MinRating = 1;
            public const int MaxRating = 5;
            public const int MaxCommentsLength = 1024;
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

        public static class Instructor
        {
            public const int MaxBiographyLength = 500;
            public const int MinBiographyLength = 10;

            public const int MaxSpecializationsLength = 100;
            public const int MinSpecializationsLength = 10;

            public const int MaxLicenseNumberLenght = 6;
            public const int MinLicenseNumberLenght = 6;
        }
    }
}
