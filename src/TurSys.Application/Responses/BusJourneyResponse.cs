using Newtonsoft.Json;

namespace TurSys.Application.Responses;
#nullable disable
public record BusJourneyResponse
{

    [JsonProperty("origin-location")]
    public string OriginLocation { get; set; }
    [JsonProperty("destination-location")]
    public string DestinationLocation { get; set; }

    [JsonProperty("is-active")]
    public bool IsActive { get; set; }
    [JsonProperty("journey")]
    public JourneyResponse Journey { get; set; }


    [JsonProperty("id")]
    public int Id { get; set; }
    [JsonProperty("partner-id")]
    public int PartnerId { get; set; }
    [JsonProperty("partner-name")]
    public string PartnerName { get; set; }
    [JsonProperty("route-id")]
    public int RouteId { get; set; }
    [JsonProperty("bus-type")]
    public string BusType { get; set; }
    [JsonProperty("bus-type-name")]
    public string BusTypeName { get; set; }
    [JsonProperty("total-seats")]
    public int TotalSeats { get; set; }
    [JsonProperty("available-seats")]
    public int AvailableSeats { get; set; }


    //[JsonProperty("policy")]
    //public PolicyResponse Policy { get; set; }

    //[JsonProperty("features")]
    //public List<FeatureResponse> Features { get; set; }


    //[JsonProperty("origin-location-id")]
    //public int OriginLocationId { get; set; }
    //[JsonProperty("destination-location-id")]
    //public int DestinationLocationId { get; set; }
    //[JsonProperty("is-promoted")]
    //public bool IsPromoted { get; set; }
    //[JsonProperty("cancellation-offset")]
    //public int CancellationOffset { get; set; }
    //[JsonProperty("has-bus-shuttle")]
    //public bool HasBusShuttle { get; set; }
    //[JsonProperty("disable-sales-without-gov-id")]
    //public bool DisableSalesWithoutGovId { get; set; }
    //[JsonProperty("display-offset")]
    //public string DisplayOffset { get; set; }
    //[JsonProperty("partner-rating")]
    //public double PartnerRating { get; set; }
    //[JsonProperty("has-dynamic-pricing")]
    //public bool HasDynamicPricing { get; set; }
    //[JsonProperty("disable-sales-without-hes-code")]
    //public bool DisableSalesWithoutHesCode { get; set; }
    //[JsonProperty("disable-single-seat-selection")]
    //public bool DisableSingleSeatSelection { get; set; }
    //[JsonProperty("change-offset")]
    //public int ChangeOffset { get; set; }
    //[JsonProperty("rank")]
    //public int Rank { get; set; }
    //[JsonProperty("display-coupon-code-input")]
    //public bool DisplayCouponCodeInput { get; set; }
    //[JsonProperty("disable-sales-without-date-of-birth")]
    //public bool DisableSalesWithoutDateOfBirth { get; set; }
    //[JsonProperty("open-offset")]
    //public int OpenOffset { get; set; }
    //[JsonProperty("display-buffer")]
    //public string DisplayBuffer { get; set; }
    //[JsonProperty("allow-sales-foreign-passenger")]
    //public bool AllowSalesForeignPassenger { get; set; }
    //[JsonProperty("has-seat-selection")]
    //public bool HasSeatSelection { get; set; }

    //[JsonProperty("branded-fares")]
    //public IList<object> BrandedFares { get; set; }

    //[JsonProperty("has-gender-selection")]
    //public bool HasGenderSelection { get; set; }
    //[JsonProperty("has-dynamic-cancellation")]
    //public bool HasDynamicCancellation { get; set; }
    //[JsonProperty("partner-terms-and-conditions")]
    //public object PartnerTermsAndConditions { get; set; }
    //[JsonProperty("partner-available-alphabets")]
    //public string PartnerAvailableAlphabets { get; set; }
    //[JsonProperty("provider-id")]
    //public int ProviderId { get; set; }
    //[JsonProperty("partner-code")]
    //public string PartnerCode { get; set; }
    //[JsonProperty("enable-full-journey-display")]
    //public bool EnableFullJourneyDisplay { get; set; }
    //[JsonProperty("provider-name")]
    //public string ProviderName { get; set; }
    //[JsonProperty("enable-all-stops-display")]
    //public bool EnableAllStopsDisplay { get; set; }
    //[JsonProperty("is-destination-domestic")]
    //public bool IsDestinationDomestic { get; set; }
    //[JsonProperty("min-len-gov-id")]
    //public object MinLenGovId { get; set; }
    //[JsonProperty("max-len-gov-id")]
    //public object MaxLenGovId { get; set; }
    //[JsonProperty("require-foreign-gov-id")]
    //public bool RequireForeignGovId { get; set; }
    //[JsonProperty("is-cancellation-info-text")]
    //public bool IsCancellationInfoText { get; set; }
    //[JsonProperty("cancellation-offset-info-text")]
    //public object CancellationOffsetInfoText { get; set; }
    //[JsonProperty("is-time-zone-not-equal")]
    //public bool IsTimeZoneNotEqual { get; set; }
    //[JsonProperty("markup-rate")]
    //public double MarkupRate { get; set; }




}

public record JourneyResponse
{
    [JsonProperty("kind")]
    public string Kind { get; set; }
    //[JsonProperty("code")]
    //public string Code { get; set; }
    //[JsonProperty("stops")]
    //public List<StopResponse> Stops { get; set; }
    [JsonProperty("origin")]
    public string Origin { get; set; }
    [JsonProperty("destination")]
    public string Destination { get; set; }
    [JsonProperty("departure")]
    public DateTime Departure { get; set; }
    [JsonProperty("arrival")]
    public DateTime Arrival { get; set; }

    [JsonProperty("currency")]
    public string Currency { get; set; }
    [JsonProperty("duration")]
    public string Duration { get; set; }
    [JsonProperty("original-price")]
    public decimal? OriginalPrice { get; set; }
    [JsonProperty("internet-price")]
    public decimal? InternetPrice { get; set; }
    [JsonProperty("provider-internet-price")]
    public decimal? ProviderInternetPrice { get; set; }
    //[JsonProperty("booking")]
    //public object Booking { get; set; }

    //[JsonProperty("bus-name")]
    //public string BusName { get; set; }

    //[JsonProperty("policy")]
    //public PolicyResponse Policy { get; set; }

    //[JsonProperty("features")]
    //public IList<string> Features { get; set; }

    //[JsonProperty("description")]
    //public string Description { get; set; }

    //[JsonProperty("available")]
    //public object Available { get; set; }

    //[JsonProperty("partner-provider-code")]
    //public object PartnerProviderCode { get; set; }

    //[JsonProperty("peron-no")]
    //public object PeronNo { get; set; }

    //[JsonProperty("partner-provider-id")]
    //public object PartnerProviderId { get; set; }

    //[JsonProperty("is-segmented")]
    //public bool IsSegmented { get; set; }

    //[JsonProperty("partner-name")]
    //public object PartnerName { get; set; }

    //[JsonProperty("provider-code")]
    //public object ProviderCode { get; set; }
    public record StopResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("kolayCarLocationId")]
        public int? KolayCarLocationId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("station")]
        public string Station { get; set; }
        [JsonProperty("time")]
        public DateTime Time { get; set; }
        [JsonProperty("is-origin")]
        public bool IsOrigin { get; set; }
        [JsonProperty("is-destination")]
        public bool IsDestination { get; set; }
    }


}

public record PolicyResponse
{
    [JsonProperty("max-seats")]
    public int? MaxSeats { get; set; }
    [JsonProperty("max-single")]
    public int MaxSingle { get; set; }
    [JsonProperty("max-single-males")]
    public int? MaxSingleMales { get; set; }
    [JsonProperty("max-single-females")]
    public int? MaxSingleFemales { get; set; }
    [JsonProperty("mixed-genders")]
    public bool MixedGenders { get; set; }
    [JsonProperty("gov-id")]
    public bool GovId { get; set; }
    [JsonProperty("lht")]
    public bool Lht { get; set; }
}

public record FeatureResponse
{
    [JsonProperty("id")]
    public int Id { get; set; }
    [JsonProperty("priority")]
    public int Priority { get; set; }
    [JsonProperty("name")]
    public string Name { get; set; }
    [JsonProperty("description")]
    public string Description { get; set; }
    [JsonProperty("is-promoted")]
    public bool IsPromoted { get; set; }
    [JsonProperty("back-color")]
    public string BackColor { get; set; }
    [JsonProperty("fore-color")]
    public string ForeColor { get; set; }
}
#nullable restore