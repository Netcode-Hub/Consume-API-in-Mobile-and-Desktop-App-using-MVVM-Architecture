using LoginApp.Maui.Models;
using System.Net.Http.Json;

namespace LoginApp.Maui.Services;

public class LoginService : ILoginRepository
{
    public async Task<User> Login(string email, string password)
    {
        try
        {
            var client = new HttpClient();
            string localhostUrl = " https://localhost:7173/api/user/login/" + email + "/" + password;
            client.BaseAddress = new Uri(localhostUrl);
            HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
            if (response.IsSuccessStatusCode)
            {
                User user = await response.Content.ReadFromJsonAsync<User>();
                return await Task.FromResult(user);
            }
            return null;
            
        }catch(Exception ex)
        {
            await Shell.Current.DisplayAlert("Error", ex.Message, "Ok");
            return null;
        }
    }
}
