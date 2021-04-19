﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using HotelListing.Data;

namespace HotelListing.Models
{


    public class CreateCountryDto
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Country Name Is Too Long")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 2, ErrorMessage = "Short Country Name Is Too Long")]
        public string ShortName { get; set; }
    }


    public class UpdateCountryDto : CreateCountryDto
    {
        public virtual IList<CreateHotelDto> Hotels { get; set; }
    }
    public class CountryDto : CreateCountryDto
    {
        public int Id { get; set; }
        public virtual IList<HotelDto> Hotels { get; set; }

    }
}
