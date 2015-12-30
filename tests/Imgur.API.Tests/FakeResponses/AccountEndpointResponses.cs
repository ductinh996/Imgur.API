﻿namespace Imgur.API.Tests.FakeResponses
{
    public partial class AccountEndpointResponses
    {
        public const string GetAccountAsync =
            "{\"data\":{\"id\":12456, \"url\":\"Bob\", \"bio\":null, \"reputation\":4343, \"created\":1229591601, \"pro_expiration\":false }, \"success\":true, \"status\":200 }";

        public const string GetAccountSettingsAsync =
            "{\"data\":{\"email\":\"ImgurApiTest@noreply.com\",\"high_quality\":false,\"public_images\":false,\"album_privacy\":\"secret\",\"pro_expiration\":false,\"accepted_gallery_terms\":true,\"active_emails\":[\"ImgurApiTest@noreply.com\"],\"messaging_enabled\":true,\"comment_replies\":true,\"blocked_users\":[{\"blocked_id\":45454554,\"blocked_url\":\"Bob\"}],\"show_mature\":true,\"newsletter_subscribed\":true},\"success\":true,\"status\":200}";

        public const string SendVerificationEmailAsync =
            "{\"data\":true,\"success\":true,\"status\":200}";

        public const string SendVerificationEmailErrorAsync =
            "{\"data\":{\"error\":\"User Previously Verified\",\"request\":\"/3/account/me/verifyemail\",\"method\":\"POST\"},\"success\":false,\"status\":400}";

        public const string UpdateAccountSettingsAsync =
            "{\"data\":true,\"success\":true,\"status\":200}";

        public const string VerifyEmailAsync =
            "{\"data\":true,\"success\":true,\"status\":200}";

        public const string VerifyEmailErrorAsync =
            "{\"data\":{\"error\":\"Unauthorized\",\"request\":\"/3/account/sarah/verifyemail\",\"method\":\"GET\"},\"success\":false,\"status\":403}";
    }
}