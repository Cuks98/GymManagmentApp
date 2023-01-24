using DataBase.API.Models;
using GymMenagmentApp.App.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymMenagmentApp.App.Pages
{
    public partial class UserOverview
    {
        public List<User> Users { get; set; }
        public List<User> FilteredUserList { get; set; }
        [Inject]
        public IUserDataService UserDataService { get; set; }
        public string idFilter { get; set; }
        public string nameFilter { get; set; }
        public string lastNameFilter { get; set; }
        public string sort { get; set; }

        protected async override Task OnInitializedAsync()
        {
            idFilter = string.Empty;
            nameFilter = string.Empty;
            lastNameFilter = string.Empty;
            sort = string.Empty;
            Users = (await UserDataService.GetUsers()).Users;
            FilteredUserList = Users;
        }
        private void FilterByLastName()
        {
            Console.WriteLine("test");
        }

        private void IdFilter(ChangeEventArgs e)
        {
            FilteredUserList = new List<User>();
            idFilter = e.Value.ToString();
            //e.Value
            foreach (var user in Users)
            {
                if (user.Id.ToString().Contains(idFilter) && user.FirstName.ToString().Contains(nameFilter) 
                && user.LastName.ToString().Contains(lastNameFilter))
                {
                    FilteredUserList.Add(user);
                }
            }
            this.SortForOtherFunctions();
        }
        private void NameFilter(ChangeEventArgs e)
        {
            FilteredUserList = new List<User>();
            nameFilter = e.Value.ToString();
            //e.Value
            foreach (var user in Users)
            {
                if (user.Id.ToString().Contains(idFilter) && user.FirstName.ToString().Contains(nameFilter)
                && user.LastName.ToString().Contains(lastNameFilter))
                {
                    FilteredUserList.Add(user);
                }
            }
            this.SortForOtherFunctions();
        }
        private void LastNameFilter(ChangeEventArgs e)
        {
            FilteredUserList = new List<User>();
            lastNameFilter = e.Value.ToString();
            //e.Value
            foreach (var user in Users)
            {
                if (user.Id.ToString().Contains(idFilter) && user.FirstName.ToString().Contains(nameFilter)
                && user.LastName.ToString().Contains(lastNameFilter))
                {
                    FilteredUserList.Add(user);
                }
            }
            this.SortForOtherFunctions();
        }
        private void Sort(ChangeEventArgs e)
        {
            sort = e.Value.ToString();
            if (sort == "1")
            {
                FilteredUserList = FilteredUserList.OrderBy(o => o.Id).ToList();
            }
            else if (sort == "2")
            {
                FilteredUserList = FilteredUserList.OrderByDescending(o => o.Id).ToList();
            }
            else if (sort == "3")
            {
                FilteredUserList = FilteredUserList.OrderBy(o => o.LeftOnRegistration).ToList();
            }
            else if (sort == "4")
            {
                FilteredUserList = FilteredUserList.OrderByDescending(o => o.LeftOnRegistration).ToList();
            }
        }

        private void SortForOtherFunctions()
        {
            if (sort == "1")
            {
                FilteredUserList = FilteredUserList.OrderBy(o => o.Id).ToList();
            }
            else if (sort == "2")
            {
                FilteredUserList = FilteredUserList.OrderByDescending(o => o.Id).ToList();
            }
            else if (sort == "3")
            {
                FilteredUserList = FilteredUserList.OrderBy(o => o.LeftOnRegistration).ToList();
            }
            else if (sort == "4")
            {
                FilteredUserList = FilteredUserList.OrderByDescending(o => o.LeftOnRegistration).ToList();
            }
        }


    }

}
