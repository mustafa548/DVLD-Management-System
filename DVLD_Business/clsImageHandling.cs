using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Configuration;

namespace DVLD_Business
{
    public class clsImageHandling
    {
        private static string SupabaseUrl = ConfigurationManager.AppSettings["SupabaseUrl"];
        private static string AnonKey = ConfigurationManager.AppSettings["AnonKey"];
        private static string BucketName = ConfigurationManager.AppSettings["BucketName"];

        private static string GetGuid()
        {
            return Guid.NewGuid().ToString();
        }

        public static string ConvertImageNameToGuid(string source)
        {
            return GetGuid() + Path.GetExtension(source);
        }

        public static async Task<bool> CopyImageToFolder(string source, string ImageName)
        {
            if (!File.Exists(source))
                return false;

            try
            {
                string requestUrl = $"{SupabaseUrl}/storage/v1/object/{BucketName}/{ImageName}";
                byte[] fileBytes = File.ReadAllBytes(source);

                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("apikey", AnonKey);
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AnonKey);
                    client.DefaultRequestHeaders.Add("x-upsert", "true");

                    using (ByteArrayContent content = new ByteArrayContent(fileBytes))
                    {
                        string extension = Path.GetExtension(ImageName).ToLower().Replace(".", "");
                        string mimeType = (extension == "png") ? "image/png" : "image/jpeg";
                        content.Headers.ContentType = new MediaTypeHeaderValue(mimeType);

                        HttpResponseMessage response = await client.PostAsync(requestUrl, content);

                        return response.IsSuccessStatusCode;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public static string GetImagePath(string ImageName)
        {
            if (string.IsNullOrWhiteSpace(ImageName))
                return String.Empty;

            return $"{SupabaseUrl}/storage/v1/object/public/{BucketName}/{ImageName}";
        }

        public static async Task<bool> DeleteImageFromFolder(string ImageName)
        {
            if (string.IsNullOrWhiteSpace(ImageName))
                return false;

            try
            {
                string requestUrl = $"{SupabaseUrl}/storage/v1/object/{BucketName}/{ImageName}";

                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("apikey", AnonKey);
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AnonKey);

                    HttpResponseMessage response = await client.DeleteAsync(requestUrl);
                    return response.IsSuccessStatusCode;
                }
            }
            catch
            {
                return false;
            }
        }

    }
}
