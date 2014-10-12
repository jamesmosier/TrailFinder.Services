namespace TrailFinder.Services.ServiceModel
{
    using System;
    using ServiceStack;

    public class TrailResponse
    {
        #region Properties

        /// <summary>
        /// Gets or sets the trailhead id.
        /// </summary>
        [ApiMember(AllowMultiple = false, DataType = "Guid", Description = "The id of the trailhead.", IsRequired = true, Name = "Id", ParameterType = "body")]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the trailhead name.
        /// </summary>
        [ApiMember(AllowMultiple = false, DataType = "string", Description = "The name of the trailhead.", IsRequired = true, Name = "Name", ParameterType = "body")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the trailhead description.
        /// </summary>
        [ApiMember(AllowMultiple = false, DataType = "string", Description = "The description of the trailhead.", IsRequired = true, Name = "Description", ParameterType = "body")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the trailhead latitude coordinate.
        /// </summary>
        [ApiMember(AllowMultiple = false, DataType = "decimal", Description = "The latitude coordinate of the trailhead.", IsRequired = true, Name = "Latitude", ParameterType = "body")]
        public decimal Latitude { get; set; }

        /// <summary>
        /// Gets or sets the trailhead longitude coordinate.
        /// </summary>
        [ApiMember(AllowMultiple = false, DataType = "decimal", Description = "The longitude coordinate of the trailhead.", IsRequired = true, Name = "Longitude", ParameterType = "body")]
        public decimal Longitude { get; set; }

        #endregion
    }
}
