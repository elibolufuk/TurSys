using System.ComponentModel.DataAnnotations;

namespace TurSys.Application.Models.BusJourneyModels
{
    public record GetListBusJourneyRequestModel
    {
#nullable disable
        [Required(ErrorMessage = "Date gerekli.")]
        public string Date { get; set; }
        public GetListBusJourneyRequestModelData Data { get; set; }

        public record GetListBusJourneyRequestModelData
        {
            [Required(ErrorMessage = "Originid gerekli.")]
            public int Originid { get; set; }

            [Required(ErrorMessage = "Destinationid gerekli.")]
            public int Destinationid { get; set; }


            [Required(ErrorMessage = "Departuredate gerekli.")]
            public string Departuredate { get; set; }

        }
#nullable restore
    }
}
