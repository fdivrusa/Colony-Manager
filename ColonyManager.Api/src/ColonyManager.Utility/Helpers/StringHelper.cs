namespace ColonyManager.Utility.Helpers
{
    public static class StringHelper
    {

        public static string ReplaceEmptyWithNull(string value)
        {
            // replace empty string with null to make field optional
            return string.IsNullOrEmpty(value) ? null : value;
        }
    }
}
