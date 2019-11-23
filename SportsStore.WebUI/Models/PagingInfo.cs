using System;


namespace SportsStore.WebUI.Models
{
    //klasa ulatwiajaca przekaz danych miedzy kontrolerem a widokiem
    //nie wchodzi w sklad modelu domeny
    public class PagingInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages
        {
            get { return (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage); }
        }
    }
}