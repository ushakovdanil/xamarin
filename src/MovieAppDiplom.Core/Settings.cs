using System;

namespace Frame.AppCore.Helpers
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Plugin.Settings;
    using Plugin.Settings.Abstractions;
    using System.Runtime;

    public static class Settings
    {
        private const string UserIdKey = "userId";
        private const string TokenKey = "token";
        private const string UserEmailKey = "userEmail";
        private const string UsernameKey = "username";
        private const string UserPasswordKey = "userPassword";


        private static readonly string[] UserKeys = {
            UserIdKey,
            TokenKey,
            UserEmailKey,
            UsernameKey
        };

        private static readonly string StringDefault = string.Empty;
        private static readonly Guid GuidDefault = Guid.Empty;
        private static readonly bool BoolDefault = false;

        public static void ClearUserData()
        {
            foreach (var key in UserKeys)
            {
                AppSettings.Remove(key);
            }
        }

        private static ISettings AppSettings => CrossSettings.Current;


        public static Guid UserId
        {
            get => AppSettings.GetValueOrDefault(UserIdKey, GuidDefault);
            set => AppSettings.AddOrUpdateValue(UserIdKey, value);
        }

        public static string Username
        {
            get => AppSettings.GetValueOrDefault(UsernameKey, StringDefault);
            set => AppSettings.AddOrUpdateValue(UsernameKey, value);
        }

        public static string UserEmail
        {
            get => AppSettings.GetValueOrDefault(UserEmailKey, StringDefault);
            set => AppSettings.AddOrUpdateValue(UserEmailKey, value);
        }
        public static string UserPassword
        {
            get => AppSettings.GetValueOrDefault(UserPasswordKey, StringDefault);
            set => AppSettings.AddOrUpdateValue(UserPasswordKey, value);
        }
    }
}
