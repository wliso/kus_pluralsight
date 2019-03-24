using kus_pluralsight2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace kus_pluralsight2.ViewModels
{
    public class GigFormViewModel
    {
        [Required]
        public String Venue { get; set; }

        [Required]
        [FutureDate]
        public string Date { get; set; }

        [Required]
        [ValidTime]
        public string Time { get; set; }

        [Required]
        public byte Genre { get; set; }

        public IEnumerable<Genre> Genres { get; set; }

        public DateTime GetDateTime()
        {
                return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}