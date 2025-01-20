﻿
namespace IMS.Common
{
    public static class ErrorMessageConstants
    {
        public const string RequiredMessage = "The {0} field is required";

        public const string LengthMessage = "The field {0} must be between {2} and {1} characters long";

        public const string LicenseNumberExistsInDb = "License number already exists. Enter another one";

        public const string UserMessageSuccess = "UserMessageSuccess";

        public const string UserMessageError = "UserMessageError";

        public const string LicenseNumberIsNotDiscoverable = "License number is not discoverable";

        public const string LicenseNumberIsNotValid = "License number is invalid";
    }
}
