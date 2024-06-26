using DataAccessBridge.Utils;

namespace DataAccessBridge.DTO
{
    /// <summary>
    /// Objeto que representa una mesa electoral
    /// </summary>
    public class MesaDTO
    {

        #region Properties

        /// <summary>
        /// Identificador de la mesa
        /// </summary>
        public long Id { get; set; } = Constants.LONG_UNDEFINED;

        /// <summary>
        /// Nombre de la mesa
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Descripción
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Observaciones
        /// </summary>
        public string Observations { get; set; } = string.Empty;

        /// <summary>
        /// Lista de candidaturas electorales con votos en la mesa actual
        /// </summary>
        public List<CandidaturaDTO> Candidaturas { get; set; } = new List<CandidaturaDTO>(0);

        /// <summary>
        /// Votos en blanco
        /// </summary>
        public long WhiteVotes { get; set; } = Constants.LONG_UNDEFINED;

        /// <summary>
        /// Votos nulos
        /// </summary>
        public long NullVotes { get; set; } = Constants.LONG_UNDEFINED;

        #endregion Properties

        #region Constructor

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public MesaDTO() { }

        #endregion Constructor

        #region Public Methods

        /// <summary>
        /// Clona el objeto actual
        /// </summary>
        /// <returns>Una clonación del objeto actual</returns>
        public object Clone()
        {
            MesaDTO result = new MesaDTO()
            {
                Id = this.Id,
                Name = this.Name,
                Description = this.Description,
                Observations = this.Observations,
                WhiteVotes = this.WhiteVotes,
                NullVotes = this.NullVotes
            };

            // Se clonan también las candidaturas
            List<CandidaturaDTO> candidaturas = new List<CandidaturaDTO>(this.Candidaturas.Count);
            this.Candidaturas.ForEach(c =>
            {
                candidaturas.Add(c.Clone() as CandidaturaDTO);
            });

            result.Candidaturas = candidaturas; // Se añaden

            return result;
        }

        /// <summary>
        /// Compara el objeto actual con el objeto recibido y devuelve un booleano que indica si son iguales
        /// </summary>
        /// <param name="obj">Objeto a comparar con el objeto actual</param>
        /// <returns>Un booleano que indica si el objeto actual es igual al recibido como parámetro</returns>
        public override bool Equals(object? obj)
        {
            bool result;

            MesaDTO? dTO = obj as MesaDTO;

            if (dTO == null)
            {
                result = false;
            }
            else
            {
                result = (
                    dTO.Id == this.Id &&
                    dTO.Name == this.Name &&
                    dTO.Description == this.Description &&
                    dTO.Observations == this.Observations &&
                    dTO.Candidaturas.SequenceEqual(this.Candidaturas) &&
                    dTO.WhiteVotes == this.WhiteVotes &&
                    dTO.NullVotes == this.NullVotes
                    );
            }

            return result;
        }

        /// <summary>
        /// Devuelve una cadena representativa del objeto actual
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Id: {this.Id}, Name: {this.Name}, Description: {this.Description}, Observations: {this.Observations}, Candidaturas (Count): {this.Candidaturas.Count}, WhiteVotes: {this.WhiteVotes}, NullVotes: {this.NullVotes}";
        }

        #endregion Public Methods

    }
}