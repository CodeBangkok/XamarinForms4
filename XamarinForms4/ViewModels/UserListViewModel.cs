using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using XamarinForms4.Models;
using System.Linq;

namespace XamarinForms4.ViewModels
{
    public class UserListViewModel : BaseViewModel
    {
        private List<User> _users;
        public List<User> Users
        {
            get => _users;
            set { _users = value; OnPropertyChanged("Users"); }
        }

        public UserListViewModel()
        {
            Users = new List<User>();
            GetUsers(20);
        }

        private async void GetUsers(int amount)
        {
            try
            {
                IsLoading = true;
                var response = await new HttpClient().GetAsync($"https://randomuser.me/api?results={amount}&nat=us");

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var customer = JsonConvert.DeserializeObject<Customer>(json);
                    Users = customer.results.Select(c => new User
                    {
                        Name = $"{c.name.first} {c.name.last}",
                        Email = c.email,
                        Phone = c.phone,
                        Picture = c.picture.large
                    }).ToList();
                }
                IsLoading = false;
            }
            catch (Exception)
            {
                IsLoading = false;
            }

        }
    }
}
