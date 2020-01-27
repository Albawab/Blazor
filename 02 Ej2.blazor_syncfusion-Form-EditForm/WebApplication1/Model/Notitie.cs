namespace HenE_Application.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Text.Json.Serialization;

    public class Notitie
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Notitie"/> class.
        /// </summary>
        /// <param name="id">Id.</param>
        public Notitie(int id)
        {
            this.Id = id;
        }

        [Required]
        [JsonConverter(typeof(Int32))]
        public Int32 Id { get; private set; }

        [Required]
        public string Title { get; set; } = "r";

        public string Body { get; set; } = "b";

        [Required]
        public DateTime Datum { get; set; }
    }
}
