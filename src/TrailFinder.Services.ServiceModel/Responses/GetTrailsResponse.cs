namespace TrailFinder.Services.ServiceModel.Responses
{
    using System.Collections.Generic;
    using ServiceStack;

    public class GetTrailsResponse
    {
        #region Properties

        /// <summary>
        /// Gets or sets the trailheads.
        /// </summary>
        [ApiMember(AllowMultiple = false, DataType = "TrailResponse", Description = "The list of the trailheads.", IsRequired = true, Name = "Trails", ParameterType = "body")]
        public List<TrailResponse> Trails { get; set; }


        #endregion
    }
}
