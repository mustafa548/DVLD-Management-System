using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Win32;
using MimeKit;
using PhoneNumbers;
using System;
using System.Diagnostics;

namespace DVLD_Business
{
    public class clsGlobal
    {
        private static string keyName = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";
        private static string valueName = "UserName";

        public enum enApplicationTypes
        {
            enNewDrivingLicense = 1,
            enRetakeTest = 2,
            enRenewDrivingLicense = 3,
            enReplacementForLost = 4,
            enReplacementForDamaged = 5,
            enRealiseDetainedLicense = 6,
            enIssueInternationalLicense = 7
        }

        public static clsUser CurrentUser = new clsUser();

        public static bool SendEmail(string toEmail, string subject, string body)
        {
            try
            {
                var message = new MimeMessage();

                message.From.Add(new MailboxAddress("DVLD", clsSettings.fromEmail));
                message.To.Add(MailboxAddress.Parse(toEmail));

                message.Subject = subject;

                message.Body = new TextPart("plain") { Text = body };

                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);

                    client.Authenticate(clsSettings.fromEmail, clsSettings.appPassword);

                    client.Send(message);

                    client.Disconnect(true);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static string GetWhatsAppFormattedNumber(string Phone, string CountryCode)
        {
            if (string.IsNullOrWhiteSpace(Phone))
                return null;

            var phoneUtil = PhoneNumberUtil.GetInstance();

            try
            {
                string regionCode = CountryCode.ToUpper();

                if (int.TryParse(CountryCode, out int callingCode))
                {
                    regionCode = phoneUtil.GetRegionCodeForCountryCode(callingCode);
                }

                PhoneNumber numberProto = phoneUtil.Parse(Phone, regionCode);

                if (!phoneUtil.IsValidNumber(numberProto))
                {
                    return null;
                }

                string formattedE164 = phoneUtil.Format(numberProto, PhoneNumberFormat.E164);
                string whatsappNumber = formattedE164.Replace("+", "").Trim();

                return whatsappNumber;
            }
            catch (NumberParseException)
            {
                return null;
            }
        }

        public static void OpenWhatsApp(string Phone, string Message, string CountryCode)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = $"https://wa.me/{GetWhatsAppFormattedNumber(Phone, CountryCode)}?text={Uri.EscapeDataString(Message)}",
                UseShellExecute = true
            });
        }

        public static bool SetValueOfUserNameInRegistry(string value)
        {
            try
            {
                Registry.SetValue(keyName, valueName, value);

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public static string GetUserNameFromRegistry()
        {
            try
            {
                string value = Registry.GetValue(keyName, valueName, null) as string;

                return value != null ? value : "";
            }
            catch(Exception ex)
            {
                return "";
            }
        }

        public static string GenerateOTP()
        {
            Random rnd = new Random();
            return rnd.Next(100000, 1000000).ToString();
        }

        public static bool HandlePasswordResetLimit(clsUser User)
        {
            if (User.LastAttemptAt != null && DateTime.Now - User.LastAttemptAt > TimeSpan.FromHours(24))
                User.Attempts = 3;

            if (User.Attempts != 0)
            {
                User.Attempts--;
            }
            else if (User.PasswordBlockedUntil == null)
            {
                User.PasswordBlockedUntil = DateTime.Now.AddHours(12);
                User.Save();
                return false;
            }
            else if (User.PasswordBlockedUntil < DateTime.Now)
            {
                User.Attempts = 2;
                User.PasswordBlockedUntil = null;
            }
            else
            {
                return false;
            }

            User.LastAttemptAt = DateTime.Now;
            User.Save();
            return true;
        }

        public static bool DefaultPasswordResetLimit(clsUser User)
        {
            User.Attempts = 3;
            User.LastAttemptAt = null;
            User.PasswordBlockedUntil = null;

            return User.Save();
        }

    }
}
