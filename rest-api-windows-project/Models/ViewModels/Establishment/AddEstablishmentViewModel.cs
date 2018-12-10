﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace stappBackend.Models.ViewModels.Establishment
{
    public class AddEstablishmentViewModel
    {
        [Required(ErrorMessage = "{0} is verplicht.")]
        public int EstablishmentId { get; set; }

        [Required(ErrorMessage = "{0} is verplicht.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} is verplicht.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "{0} is verplicht.")]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "{0} is verplicht.")]
        public string City { get; set; }

        [Required(ErrorMessage = "{0} is verplicht.")]
        public string Street { get; set; }

        [Required(ErrorMessage = "{0} is verplicht.")]
        public string HouseNumber { get; set; }

        [Required(ErrorMessage = "{0} is verplicht.")]
        public List<CategoryViewModel> Categories { get; set; }

        [Required(ErrorMessage = "{0} is verplicht.")]
        public List<SocialMediaViewModel> SocialMedias { get; set; }

        [Required(ErrorMessage = "{0} is verplicht.")]
        public List<OpenDayViewModel> OpenDays { get; set; }

        [Required(ErrorMessage = "{0} is verplicht.")]
        public List<ExceptionalDayViewModel> ExceptionalDays { get; set; }

        [Required(ErrorMessage = "{0} is verplicht.")]
        [DataType(DataType.Upload)]
        public IFormCollection Images { set; get; }
    }
}
